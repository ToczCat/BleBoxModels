using BleBoxModels.Common.Enums;
using BleBoxModels.Common.Models;
using BleBoxModels.SmartWindowBox.Enums;

namespace BleBoxModels.SmartWindowBox.Models;

public record Settings : SettingsBase
{
    public WindowSet? Window { get; set; }
}

public record WindowSet
{
    public MotorSet[]? Motors { get; set; }
    public SensorSet[]? Sensors { get; set; }
}

public record MotorSet
{
    public int Id { get; set; }
    public Toggle Enabled { get; set; }
    public LockOtherMotors LockOtherMotorsIfNotClose { get; set; }
    public string? Name { get; set; }
    public ControlType? ControlType { get; set; }
    public MoveDirectionSwap MoveDirectionSwap { get; set; }
    public MotorCalibrationParameters? CalibrationParameters { get; set; }
    public uint MoveTimeoutMs { get; set; }
    public SensorsReaction? SensorsReaction { get; set; }
}

public record MotorCalibrationParameters
{
    public Calibration IsCalibrated { get; set; }
}

public record SensorsReaction
{
    public Toggle Rain { get; set; }
}

public record SensorSet
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public SensorSettings? Settings { get; set; }
}

public record SensorSettings
{
    public Toggle Enabled { get; set; }
}
