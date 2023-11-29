using s2clientprotocol.NET.Sc2;
using SC2APIProtocol;

namespace s2clientprotocol.NET.SquadronTD;

public class SquadClient
{
    private readonly int ownerId;

    private readonly Sc2Client sc2Client = null!;

    public SquadClient(bool startup = true, bool realtime = true, int ownerId = 1)
    {
        this.ownerId = ownerId;

        this.sc2Client = new Sc2Client(startup: startup);
        this.sc2Client.Ping();

        this.sc2Client.CreateGame(
            realtime: realtime,
            mapFile: "SquadronTD.SC2Map",

            new PlayerSetup
            {
                Race = Race.NoRace,
                Type = PlayerType.Participant
            }
        );

        this.sc2Client.JoinGame(Race.NoRace);
        this.sc2Client.LoadData();

    }

    public Response ExecuteUnitAbility(string unitName, string abilityName, string? positionName = null)
    {
        var units = this.sc2Client.GetUnits(this.ownerId);
        var unit = units.Single(x => x.name == unitName).unit;

        var abilities = this.sc2Client.GetAbilitiesByName(unit.Tag);
        var abilityId = abilities[abilityName].AbilityId;

        if (positionName == null)
        {
            return this.sc2Client.ExecuteAbilityCommand(unit.Tag, abilityId);
        }

        var x = 17 - 2 + int.Parse(positionName[1].ToString()) * 2;
        var y = 99 + 2 - ((byte)positionName[0] - 64) * 2;

        return this.sc2Client.ExecuteAbilityCommand(unit.Tag, abilityId, (x, y));
    }

    public SquadInfos GetInfos()
    {
        var observation = this.sc2Client.Observe();
        var playerObs = observation.Observation.PlayerCommon;

        var upgrades = this.sc2Client.GetUpgrades(observation);

        return new SquadInfos
        {
            BuildPhase = upgrades.Any(x => x.Name == "BuildPhase"),
            Minerals = playerObs.Minerals,
            Gas = playerObs.Vespene,
            CurrentSupply = playerObs.FoodUsed,
            MaxSupply = playerObs.FoodCap,
        };
    }
}
