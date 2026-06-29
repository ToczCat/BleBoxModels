namespace BleBoxModels.TempSensor.Models;

public record TempSensorSettings
{
    public Dictionary<string, int>? UserTempOffset { get; set; }
}
