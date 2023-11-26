using SC2APIProtocol;

namespace s2clientprotocol.NET;

public class SquadronTD
{
    private readonly int ownerId;

    private readonly Sc2Client sc2Client = null!;

    public SquadronTD(bool joinOnly = false, int ownerId = 1)
    {
        this.ownerId = ownerId;

        this.sc2Client = new Sc2Client(startup: !joinOnly);
        this.sc2Client.Ping().Wait();

        if (!joinOnly)
        {
            this.sc2Client.CreateGame(
                realtime: true,
                mapFile: "SquadronTD.SC2Map",

                new PlayerSetup
                {
                    Race = Race.NoRace,
                    Type = PlayerType.Participant
                }
            ).Wait();
            Console.WriteLine("game created");
        }

        this.sc2Client.JoinGame(Race.NoRace).Wait();
        Console.WriteLine("game joined");

        this.sc2Client.LoadData().Wait();
        Console.WriteLine("data loaded");
    }

    public async Task<Response> ExecuteUnitAbility(string unitName, string abilityName, string? positionName = null)
    {
        var units = await this.sc2Client.GetUnits(this.ownerId);
        var unit = units.Single(x => x.name == unitName).unit;

        var abilities = await this.sc2Client.GetAbilitiesByName(unit.Tag);
        var abilityId = abilities[abilityName].AbilityId;

        if (positionName == null)
        {
            return await this.sc2Client.ExecuteAbilityCommand(unit.Tag, abilityId);
        }

        var x = 17 - 2 + (int.Parse(positionName[1].ToString()) * 2);
        var y = 99 + 2 - (((byte)positionName[0] - 64) * 2);

        return await this.sc2Client.ExecuteAbilityCommand(unit.Tag, abilityId, (x, y));
    }

    public async Task GetInfos()
    {
        var observation = await this.sc2Client.Observe();
        
    }
}
