using BleBoxModels.GateBox.Enums;

namespace BleBoxModels.GateBox.Models;

public record GateExtended : Gate
{
    public OpenCloseMode? OpenCloseMode { get; set; }
    public GateType? GateType { get; set; }
    public int GatePulseTimeMs { get; set; }
    public ExtraButtonType? ExtraButtonType { get; set; }
    public int? ExtraButtonPulseTimeMs { get; set; }
    public InputsType? InputsType { get; set; }
}
