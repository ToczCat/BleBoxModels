using BleBoxModels.SwitchBox.Enums;

namespace BleBoxModels.SwitchBox.Models;

public record RelayExtended : Relay
{
    public StateAfterRestart StateAfterRestart { get; set; }
    public int DefaultForTime { get; set; }
}
