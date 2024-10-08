﻿using SC2APIProtocol;

namespace s2clientprotocol.NET.SquadronTD;

public record SquadInfos
{
    public bool BuildPhase { get; set; }
    public uint Minerals { get; set; }
    public uint Gas { get; set; }
    public uint CurrentSupply { get; set; }
    public uint MaxSupply { get; set; }

    public (string name, Unit unit)[] Units { get; set; } = null!;
    public Unit Builder { get; set; } = null!;
    public Unit SecuritySysten { get; set; } = null!;
    public Unit WarCenter { get; set; } = null!;
    public Dictionary<string, Unit> SendBuildings { get; set; } = null!;
}
