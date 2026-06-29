using BleBoxModels.ShutterBox.Enums;

namespace BleBoxModels.ShutterBox.Models;

public record ShutterExtended : Shutter
{
    public ControlType? ControlType { get; set; }
    public int TiltMinAngle { get; set; }
    public int TiltMaxAngle { get; set; }
    public TiltDisplayUnit? TiltDisplayUnit { get; set; }
    public CalibrationParameters? CalibrationParameters { get; set; }
}

public record CalibrationParameters
{
    public IsCalibrated IsCalibrated { get; set; }
    public int MaxMoveTimeUpMs { get; set; }
    public int MaxMoveTimeDownMs { get; set; }
    public uint MaxTiltTimeUpMs { get; set; }
    public uint MaxTiltTimeDownMs { get; set; }
}
