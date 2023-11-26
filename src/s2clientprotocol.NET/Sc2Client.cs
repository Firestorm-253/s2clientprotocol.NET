using System.Diagnostics;
using System.Net.WebSockets;

using Google.Protobuf;
using SC2APIProtocol;

namespace s2clientprotocol.NET;

public class Sc2Client
{
    public const string SC2_PATH = "C:\\Program Files (x86)\\StarCraft II";
    private readonly ClientWebSocket clientWebSocket;

    public UnitTypeData[] Units { get; private set; } = null!;
    public UpgradeData[] Upgrades { get; private set; } = null!;
    public AbilityData[] Abilities { get; private set; } = null!;

    public Sc2Client(bool startup = true, string ipAdress = "127.0.0.1", int port = 8268)
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
        var resp = await this.SendAsync(new Request
        {
            Data = new RequestData
            {
                UnitTypeId = true,
                UpgradeId = true,
                AbilityId = true,
            },
        });

        var data = resp.Data;

        this.Units = data.Units.ToArray();
        this.Upgrades = data.Upgrades.ToArray();
        this.Abilities = data.Abilities.ToArray();
    }

    public async Task<Response> SendAsync(Request req)
    {
        int failCounter = 0;
        while (true)
        {
            await using var sendStream = new MemoryStream();
            req.WriteTo(sendStream);
            await this.clientWebSocket.SendAsync(sendStream.ToArray(), WebSocketMessageType.Binary, WebSocketMessageFlags.EndOfMessage, CancellationToken.None);
            await sendStream.FlushAsync();
            sendStream.Close();

            await using var receiveStream = new MemoryStream();
            while (true)
            {
                var buffer = new ArraySegment<byte>(new byte[1024 * 1024]);
                var result = await this.clientWebSocket.ReceiveAsync(buffer, CancellationToken.None);

                if (buffer.Array != null)
                {
                    receiveStream.Write(buffer.Array, 0, result.Count);
                }
                if (result.EndOfMessage)
                {
                    break;
                }
            }
            receiveStream.Seek(0, SeekOrigin.Begin);

            var response = Response.Parser.ParseFrom(receiveStream);
            await receiveStream.FlushAsync();
            receiveStream.Close();

            if (response.Error.Any())
            {
                failCounter++;

                if (failCounter > 1)
                {
                }
            }
            else
            {
                return response;
            }
        }
    }

    public async Task Ping()
    {
        var response = await this.SendAsync(new Request { Ping = new RequestPing() });
        Console.WriteLine(response);
    }

    public async Task<Response> CreateGame(bool realtime = true, string mapFile = "Ladder2019Season3\\AcropolisLE.SC2Map", params PlayerSetup[] players)
    {
        var response = await this.SendAsync(new Request
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

        return response;
    }

    public async Task<Response> JoinGame(Race race)
    {
        var response = await this.SendAsync(new Request
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

        return response;
    }

    public async Task<ResponseObservation> Observe()
    {
        var response = await this.SendAsync(new Request { Observation = new RequestObservation() });
        return response.Observation; 
    }

    public async Task<(string name, Unit unit)[]> GetUnits(int owner = -1, ResponseObservation? observation = null)
    {
        observation ??= await this.Observe();
        var units = observation.Observation.RawData.Units;

        return units
            .Where(x => owner == -1 ? true : x.Owner == owner)
            .Select(x => (this.Units[x.UnitType].Name, x))
            .ToArray();
    }

    public async Task<UpgradeData[]> GetUpgrades(ResponseObservation? observation = null)
    {
        observation ??= await this.Observe();
        var upgrades = observation.Observation.RawData.Player.UpgradeIds;

        return upgrades
            .Select(x => this.Upgrades[x])
            .ToArray();
    }

    public async Task<Dictionary<string, AvailableAbility>> GetAbilitiesByName(ulong unitTag)
    {
        var req = new Request { Query = new RequestQuery() };
        req.Query.Abilities.Add(new RequestQueryAvailableAbilities { UnitTag = unitTag });
        var response = await this.SendAsync(req);

        var abilities = response.Query.Abilities[0].Abilities.ToArray();
        return abilities.ToDictionary(x => (this.Abilities[x.AbilityId].ButtonName ?? this.Abilities[x.AbilityId].FriendlyName).TrimStart('f'), x => x);
    }

    public async Task<Response> ExecuteAction(SC2APIProtocol.Action action)
    {
        var response = await this.SendAsync(new Request { Action = new RequestAction { Actions = { action } } });
        return response;
    }

    public async Task<Response> MoveCamera(float x, float y)
    {
        return await this.ExecuteAction(new SC2APIProtocol.Action
        {
            ActionRaw = new ActionRaw
            {
                CameraMove = new ActionRawCameraMove
                {
                    CenterWorldSpace = new Point
                    {
                        X = x,
                        Y = y
                    }
                }
            }
        });
    }

    public async Task<Response> ExecuteAbilityCommand(ulong unitTag, int abilityId, (float x, float y)? position = null)
    {
        var action = new SC2APIProtocol.Action
        {
            ActionRaw = new ActionRaw
            {
                UnitCommand = new ActionRawUnitCommand
                {
                    UnitTags = { unitTag },
                    AbilityId = abilityId
                },
            }
        };

        if (position != null)
        {
            action.ActionRaw.UnitCommand.TargetWorldSpacePos = new Point2D()
            {
                X = position.Value.x,
                Y = position.Value.y
            };
        }

        return await this.ExecuteAction(action);
    }
}
