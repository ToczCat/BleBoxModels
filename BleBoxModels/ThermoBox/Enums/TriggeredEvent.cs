namespace BleBoxModels.ThermoBox.Enums;

public enum TriggeredEvent
{
    InitializationInProgress = 1,
    NoProbesConnected = 2,
    FewerProbesThanExpected = 3,
    MoreProbesThanExpected = 4,
    AmbientProbeFault = 5,
    SafetyProbeFault = 6,
    BothProbesFault = 7,
    ProbesReplaced = 8,
    UnknownProbeOrder = 9,
    UnknownMode = 10,
    UnknownError = 11,
    TemperatureRangeExceeded = 12
}
