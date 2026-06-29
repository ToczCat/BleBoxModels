using BleBoxModels.GateBox.Enums;

namespace BleBoxModels.GateBox.Models;

public record Gate
{
    public CurrentPos? CurrentPos { get; set; }
    public OutputState? GateOutputState { get; set; }
    public OutputState? ExtraButtonOutputState { get; set; }
}
