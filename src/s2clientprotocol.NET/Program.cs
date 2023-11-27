using s2clientprotocol.NET.SquadronTD;

var squadClient = new SquadClient(startup: false);

Console.WriteLine("\npress any key when game started\n");
Console.ReadKey();

var resp = squadClient.ExecuteUnitAbility("NatureBuilder", "Halfbreed", "A1");

while (true)
{
    var squadInfos = squadClient.GetInfos();
}

//var resp = await squadClient.ExecuteUnitAbility("WarCenter", "UpgradeAmount");
//var resp = await squadClient.ExecuteUnitAbility("WarCenter", "UpgradeSpeed");
//var resp = await squadClient.ExecuteUnitAbility("WarCenter", "UpgradeSupply");