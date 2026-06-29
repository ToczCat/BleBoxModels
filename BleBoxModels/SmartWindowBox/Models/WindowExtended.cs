using BleBoxModels.SmartWindowBox.Enums;

namespace BleBoxModels.SmartWindowBox.Models;

public record WindowExtended
{
    public SensorExtended[]? Sensors { get; set; }
    public MotorExtended[]? Motors { get; set; }
}

public record SensorExtended
{
    public Sensor? State { get; set; }
    public double IconSet { get; set; }
    public string? Name { get; set; }
}

public record MotorExtended : Motor
{
    public MotorState State { get; set; }
    public ControlType? ControlType { get; set; }
    public CalibrationParameters? CalibrationParameters { get; set; }
}

public record CalibrationParameters
{
    public Calibration IsCalibrated { get; set; }
    public int MaxMoveTimeUpMs { get; set; }
    public int MaxMoveTimeDownMs { get; set; }
}
