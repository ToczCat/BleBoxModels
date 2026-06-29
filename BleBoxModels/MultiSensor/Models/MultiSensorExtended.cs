namespace BleBoxModels.MultiSensor.Models;

public record MultiSensorExtended : MultiSensor
{
    public new SensorExtended[]? Sensors { get; set; }
    public int NotConfiguredProbes { get; set; }
}
