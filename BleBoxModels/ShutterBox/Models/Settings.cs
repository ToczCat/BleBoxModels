using BleBoxModels.Common.Enums;
using BleBoxModels.Common.Models;
using BleBoxModels.ShutterBox.Enums;

namespace BleBoxModels.ShutterBox.Models;

public record Settings : SettingsBase
{
    public ShutterSet? Shutter { get; set; }
}

public record ShutterSet
{
    public ControlType? ControlType { get; set; }
    public Limit? Limit { get; set; }
    public SafetySettings? Safety { get; set; }
    public uint SoftStartMs { get; set; }
    public uint ReverseMoveMs { get; set; }
    public uint MoveTimeoutMs { get; set; }
    public int SlowModePower { get; set; }
    public int TiltMinAngle { get; set; }
    public int TiltMaxAngle { get; set; }
    public TiltDisplayUnit? TiltDisplayUnit { get; set; }
    public MoveDirectionSwap? MoveDirectionSwap { get; set; }
    public InputsSwap? InputsSwap { get; set; }
    public CalibrationParameters? CalibrationParameters { get; set; }
    public object[]? FieldsPreferences { get; set; }
}

public record Limit
{
    public LimitType? Type { get; set; }
    public uint OverloadThresholdMa { get; set; }
    public uint PowerCutThresholdMa { get; set; }
    public int PowerCutThresholdVA { get; set; }
    public object[]? FieldsPreferences { get; set; }
}

public record SafetySettings
{
    public Overload? Overload { get; set; }
}

public record Overload
{
    public Toggle Enabled { get; set; }
    public uint ThresholdMa { get; set; }
    public object[]? FieldsPreferences { get; set; }
}
