﻿using SC2APIProtocol;

namespace s2clientprotocol.NET.Sc2;

public class Sc2Client
{
    private readonly Sc2Connection connection = null!;

    public UnitTypeData[] Units { get; private set; } = null!;
    public UpgradeData[] Upgrades { get; private set; } = null!;
    public AbilityData[] Abilities { get; private set; } = null!;

    public Sc2Client(bool startup = true, string ipAdress = "127.0.0.1", int port = 8268)
    {
        this.connection = new Sc2Connection(startup, ipAdress, port);
    }

    public void Ping()
    {
        this.connection.TryWaitResponse(new Request { Ping = new RequestPing() }, out var response);

        if (response != null)
        {
            Log(response);
            return;
        }
        throw new Exception("error: ping");
    }

    public void Step(uint count)
    {
        this.connection.TryWaitResponse(new Request
        {
            Step = new RequestStep
            {
                Count = count
            }
        }, out var response);

        if (response != null)
        {
            Log(response);
            return;
        }
        throw new Exception("error: step");
    }

    public void LoadData()
    {
        this.connection.TryWaitResponse(new Request
        {
            Data = new RequestData
            {
                UnitTypeId = true,
                UpgradeId = true,
                AbilityId = true,
            },
        }, out var response, wait: 10_000);

        if (response == null)
        {
            throw new Exception("error: load data");
        }
        Log("load data");

        var data = response.Data;

        this.Units = data.Units.ToArray();
        this.Upgrades = data.Upgrades.ToArray();
        this.Abilities = data.Abilities.ToArray();
    }

    public Response CreateGame(bool realtime = true, string mapFile = "Ladder2019Season3\\AcropolisLE.SC2Map", params PlayerSetup[] players)
    {
        this.connection.TryWaitResponse(new Request
        {
            CreateGame = new RequestCreateGame
            {
                Realtime = realtime,
                LocalMap = new LocalMap
                {
                    MapPath = $"{Sc2Connection.SC2_PATH}\\Maps\\{mapFile}"
                },
                PlayerSetup =
                {
                    players,
                },
            }
        }, out var response, wait: 20_000);

        if (response != null)
        {
            Log(response);
            return response;
        }
        throw new Exception("error: create game");
    }

    public Response JoinGame(Race race)
    {
        this.connection.TryWaitResponse(new Request
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
        }, out var response, wait: 25_000);

        if (response != null)
        {
            Log(response);
            return response;
        }
        throw new Exception("error: join game");
    }

    public ResponseObservation Observe()
    {
        this.connection.TryWaitResponse(new Request { Observation = new RequestObservation() }, out var response);

        if (response != null)
        {
            Log("observation");
            return response.Observation;
        }
        throw new Exception("error: observation");
    }

    public (string name, Unit unit)[] GetUnits(int owner = -1, ResponseObservation? observation = null)
    {
        observation ??= this.Observe();
        var units = observation.Observation.RawData.Units;

        return units
            .Where(x => owner == -1 ? true : x.Owner == owner)
            .Select(x => (this.Units[x.UnitType].Name, x))
            .ToArray();
    }

    public UpgradeData[] GetUpgrades(ResponseObservation? observation = null)
    {
        observation ??= this.Observe();
        var upgrades = observation.Observation.RawData.Player.UpgradeIds;

        return upgrades
            .Select(x => this.Upgrades[x])
            .ToArray();
    }

    public Dictionary<string, AvailableAbility> GetAbilitiesByName(ulong unitTag)
    {
        var req = new Request { Query = new RequestQuery() };
        req.Query.Abilities.Add(new RequestQueryAvailableAbilities { UnitTag = unitTag });
        this.connection.TryWaitResponse(req, out var response);

        if (response == null)
        {
            throw new Exception("error: request abilities");
        }
        Log("request abilities");

        var abilities = response.Query.Abilities[0].Abilities.ToArray();
        return abilities.ToDictionary(x => (this.Abilities[x.AbilityId].ButtonName ?? this.Abilities[x.AbilityId].FriendlyName).TrimStart('f'), x => x);
    }

    public Response ExecuteAction(SC2APIProtocol.Action action)
    {
        this.connection.TryWaitResponse(new Request { Action = new RequestAction { Actions = { action } } }, out var response);

        if (response != null)
        {
            Log(response);
            return response;
        }
        throw new Exception("error: execute action");
    }

    public Response MoveCamera(float x, float y)
    {
        return this.ExecuteAction(new SC2APIProtocol.Action
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

    public Response ExecuteAbilityCommand(ulong unitTag, int abilityId, (float x, float y)? position = null)
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

        return this.ExecuteAction(action);
    }
}