using BleBoxModels.SwitchBoxD.Enums;

namespace BleBoxModels.SwitchBoxD.Models;

public record Sensor
{
    public string? Type { get; set; }
    public int Value { get; set; }
    public SensorTrend Trend { get; set; }
    public SensorState State { get; set; }
}
