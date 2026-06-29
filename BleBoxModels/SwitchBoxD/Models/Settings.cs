using BleBoxModels.Common.Enums;
using BleBoxModels.Common.Models;
using BleBoxModels.SwitchBoxD.Enums;

namespace BleBoxModels.SwitchBoxD.Models;

public record Settings : SettingsBase
{
    public PowerMeasuringSet? PowerMeasuring { get; set; }
    public RelaySet[]? Relays { get; set; }
    public Switch? Switch { get; set; }
}

public record PowerMeasuringSet
{
    public Toggle Enabled { get; set; }
}

public record RelaySet
{
    public StateAfterRestart StateAfterRestart { get; set; }
    public int DefaultForTime { get; set; }
    public string? Name { get; set; }
}

public record Switch
{
    public OutputMode OutputMode { get; set; }
    public int[]? OutputOrder { get; set; }
}
