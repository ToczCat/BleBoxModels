namespace BleBoxModels.ShutterBox.Enums;

public enum State
{
    MovingDown = 0,
    MovingUp = 1,
    ManuallyStopped = 2,
    LowerLimitReached = 3,
    UpperLimitReached = 4,
    SafetyStop = 8
}
