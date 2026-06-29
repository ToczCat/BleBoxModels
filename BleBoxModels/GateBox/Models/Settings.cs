using BleBoxModels.Common.Models;
using BleBoxModels.GateBox.Enums;

namespace BleBoxModels.GateBox.Models;

public record Settings : SettingsBase
{
    public GateSet? Gate { get; set; }
}

public record GateSet
{
    public OpenCloseMode? OpenCloseMode { get; set; }
    public GateType? GateType { get; set; }
    public int GatePulseTimeMs { get; set; }
    public RelayNumber? GateRelayNumber { get; set; }
    public InvertMode? GateInvert { get; set; }
    public ExtraButtonType? ExtraButtonType { get; set; }
    public int? ExtraButtonPulseTimeMs { get; set; }
    public InvertMode? ExtraButtonInvert { get; set; }
    public RelayNumber? ExtraButtonRelayNumber { get; set; }
    public InputsType? InputsType { get; set; }
    public InputNumber? OpenLimitSwitchInputNumber { get; set; }
    public InputNumber? CloseLimitSwitchInputNumber { get; set; }
    public InvertMode? OpenLimitSwitchInputInvert { get; set; }
    public InvertMode? CloseLimitSwitchInputInvert { get; set; }
    public object[]? FieldsPreferences { get; set; }
}
