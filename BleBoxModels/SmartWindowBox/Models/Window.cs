using BleBoxModels.SmartWindowBox.Enums;

namespace BleBoxModels.SmartWindowBox.Models;

public record Window
{
    public Sensor[]? Sensors { get; set; }
    public Motor[]? Motors { get; set; }
}

public record Sensor
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public int? Value { get; set; }
    public SensorState State { get; set; }
    public SensorTrend Trend { get; set; }
    public int ElapsedTimeS { get; set; }
}

public record Motor
{
    public MotorPosition? CurrentPos { get; set; }
    public MotorPosition? DesiredPos { get; set; }
    public MotorPosition? FavPos { get; set; }
}

public record MotorPosition
{
    public int Position { get; set; }
}
