using BleBoxModels.SwitchBoxD.Enums;

namespace BleBoxModels.SwitchBoxD.Models;

public record RelayExtended : Relay
{
    public StateAfterRestart StateAfterRestart { get; set; }
    public int DefaultForTime { get; set; }
    public string? Name { get; set; }
}
