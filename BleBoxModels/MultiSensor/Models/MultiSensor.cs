using BleBoxModels.MultiSensor.Enums;

namespace BleBoxModels.MultiSensor.Models;

public record MultiSensor
{
    public Sensor[]? Sensors { get; set; }
}

public record Sensor
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public double? Value { get; set; }
    public State State { get; set; }
    public Trend Trend { get; set; }
    public int ElapsedTimeS { get; set; }
}

public record SensorExtended : Sensor
{
    public double IconSet { get; set; }
    public string? Name { get; set; }
}
