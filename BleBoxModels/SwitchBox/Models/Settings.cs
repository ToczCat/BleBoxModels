using BleBoxModels.Common.Enums;
using BleBoxModels.Common.Models;
using BleBoxModels.SwitchBox.Enums;

namespace BleBoxModels.SwitchBox.Models;

public record Settings : SettingsBase
{
    public PowerMeasuringSet? PowerMeasuring { get; set; }
    public RelaySet[]? Relays { get; set; }
}

public record PowerMeasuringSet
{
    public Toggle Enabled { get; set; }
}

public record RelaySet
{
    public StateAfterRestart StateAfterRestart { get; set; }
    public int DefaultForTime { get; set; }
}
