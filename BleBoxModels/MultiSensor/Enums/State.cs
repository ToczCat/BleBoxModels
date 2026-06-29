namespace BleBoxModels.MultiSensor.Enums;

public enum State
{
    Idle = 0,
    MeasurementInProgress,
    ActiveMode,
    Error,
    AboveUpperLimit,
    UnderLowerLimit
}
