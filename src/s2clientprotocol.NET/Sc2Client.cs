using Google.Protobuf;
using SC2APIProtocol;
using System;
using System.Diagnostics;
using System.Net.WebSockets;

namespace s2clientprotocol.NET;

public class Sc2Client
{
    public const string SC2_PATH = "C:\\Program Files (x86)\\StarCraft II";
    private readonly ClientWebSocket clientWebSocket;

    public UnitTypeData[] Units { get; private set; } = null!;
    public UpgradeData[] Upgrades { get; private set; } = null!;
    public AbilityData[] Abilities { get; private set; } = null!;

    public Sc2Client(bool startup = true, string ipAdress = "127.0.0.1", int port = 8168)
    {
        if (startup)
        {
            var sc2_process = Process.Start(new ProcessStartInfo(
            $"{SC2_PATH}\\Versions\\Base91115\\SC2.exe",
            $"-listen {ipAdress} -port {port} -displaymode 0 -windowwidth 1024 -windowheight 768 -windowx 0 -windowy 0")
            { WorkingDirectory = $"{SC2_PATH}\\Support" });
            sc2_process!.WaitForInputIdle();
        }

        this.clientWebSocket = new ClientWebSocket();
        this.clientWebSocket.ConnectAsync(new Uri($"ws://{ipAdress}:{port}/sc2api"), CancellationToken.None).Wait();
        Console.WriteLine("connected");
    }

    public async Task LoadData()
    {
        await this.SendAsync(new Request
        {
            Data = new RequestData
            {
                UnitTypeId = true,
                UpgradeId = true,
                AbilityId = true,
            },
        });

        var data = (await this.ReceiveAsync()).Data;

        this.Units = data.Units.ToArray();
        this.Upgrades = data.Upgrades.ToArray();
        this.Abilities = data.Abilities.ToArray();
    }

    public async Task SendAsync(Request req)
    {
        await this.clientWebSocket.SendAsync(req.ToByteArray(), WebSocketMessageType.Binary, true, CancellationToken.None);
    }

    public async Task<Response> ReceiveAsync()
    {
        await using var ms = new MemoryStream();
        while (true)
        {
            var buffer = new ArraySegment<byte>(new byte[1024 * 1024]);
            var result = await this.clientWebSocket.ReceiveAsync(buffer, CancellationToken.None);
            if (buffer.Array != null)
            {
                ms.Write(buffer.Array, 0, result.Count);
            }
            if (result.EndOfMessage)
            {
                break;
            }
        }
        ms.Seek(0, SeekOrigin.Begin);
        return Response.Parser.ParseFrom(ms);
    }

    public async Task Ping()
    {
        await this.SendAsync(new Request { Ping = new RequestPing() });
        Console.WriteLine(await this.ReceiveAsync());
    }

    public async Task CreateGame(bool realtime = true, string mapFile = "Ladder2019Season3\\AcropolisLE.SC2Map", params PlayerSetup[] players)
    {
        await this.SendAsync(new Request
        {
            CreateGame = new RequestCreateGame
            {
                Realtime = realtime,
                LocalMap = new LocalMap
                {
                    MapPath = $"{SC2_PATH}\\Maps\\{mapFile}"
                },
                PlayerSetup =
                {
                    players,
                },
            }
        });
        Console.WriteLine(await this.ReceiveAsync());
    }

    public async Task JoinGame(Race race)
    {
        await this.SendAsync(new Request
        {
            JoinGame = new RequestJoinGame
            {
                Race = race,
                Options = new InterfaceOptions
                {
                    Raw = true,
                    Score = true
                }
            }
        });
        Console.WriteLine(await this.ReceiveAsync());
    }

    public async Task<ResponseObservation> Observe()
    {
        await this.SendAsync(new Request { Observation = new RequestObservation() });
        return (await this.ReceiveAsync()).Observation; 
    }

    public async Task<(string name, Unit unit)[]> GetUnits()
    {
        var observation = await this.Observe();
        var units = observation.Observation.RawData.Units;

        return units.Select(x => (this.Units[x.UnitType].Name, x)).ToArray();
    }

    public async Task<Dictionary<string, AvailableAbility>> GetAbilitiesByName(ulong unitTag)
    {
        var req = new Request { Query = new RequestQuery() };
        req.Query.Abilities.Add(new RequestQueryAvailableAbilities { UnitTag = unitTag });
        await this.SendAsync(req);

        var abilities = (await this.ReceiveAsync()).Query.Abilities[0].Abilities.ToArray();
        return abilities.ToDictionary(x => this.Abilities[x.AbilityId].ButtonName.TrimStart('f'), x => x);
    }

    public async Task<Response> ExecuteAction(SC2APIProtocol.Action action)
    {
        await this.SendAsync(new Request { Action = new RequestAction { Actions = { action } } });
        return await this.ReceiveAsync();
    }

    public async Task<Response> MoveCamera(float x, float y)
    {
        await this.ExecuteAction(new SC2APIProtocol.Action()
        {
            ActionRaw = new ActionRaw()
            {
                CameraMove = new ActionRawCameraMove()
                {
                    CenterWorldSpace = new Point()
                    {
                        X = x,
                        Y = y
                    }
                }
            }
        });
        return await this.ReceiveAsync();
    }

    public async Task<Response> ExecuteAbilityCommand(ulong unitTag, int abilityId, string positionName)
    {
        return await this.ExecuteAction(new SC2APIProtocol.Action
        {
            ActionRaw = new ActionRaw
            {
                UnitCommand = new ActionRawUnitCommand
                {
                    UnitTags = { unitTag },
                    AbilityId = abilityId,
                    TargetWorldSpacePos = new Point2D()
                    {
                        X = 17 - 2 + (int.Parse(positionName[1].ToString()) * 2),
                        Y = 99 + 2 - (((byte)positionName[0] - 64) * 2)
                    }
                },
            }
        });
    }
}
