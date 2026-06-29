using BleBoxModels.TempSensor.Enums;

namespace BleBoxModels.TempSensor.Models;

public record TempSensor
{
    public Sensor[]? Sensors { get; set; }
}

public record Sensor
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public int? Value { get; set; }
    public Trend Trend { get; set; }
    public State State { get; set; }
    public int ElapsedTimeS { get; set; }
}
