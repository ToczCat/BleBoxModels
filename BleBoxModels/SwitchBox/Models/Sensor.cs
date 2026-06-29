using BleBoxModels.SwitchBox.Enums;

namespace BleBoxModels.SwitchBox.Models;

public record Sensor
{
    public string? Type { get; set; }
    public int Value { get; set; }
    public SensorTrend Trend { get; set; }
    public SensorState State { get; set; }
}
