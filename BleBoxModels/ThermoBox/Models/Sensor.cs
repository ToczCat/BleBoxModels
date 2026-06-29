using BleBoxModels.ThermoBox.Enums;

namespace BleBoxModels.ThermoBox.Models;

public record Sensor
{
    public int? Id { get; set; }
    public string? Type { get; set; }
    public double? Value { get; set; }
    public SensorState? State { get; set; }
    public int? PeriodS { get; set; }
}
