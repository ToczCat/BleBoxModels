using BleBoxModels.Common.Enums;
using BleBoxModels.Common.Models;
using BleBoxModels.MultiSensor.Enums;

namespace BleBoxModels.MultiSensor.Models;

public record Settings : SettingsBase
{
    public MultiSensorSet? MultiSensor { get; set; }
}

public record MultiSensorSet
{
    public EnergyMeter? EnergyMeter { get; set; }
    public SensorSet[]? Sensors { get; set; }
    public object[]? FieldsPreferences { get; set; }
}

public record EnergyMeter
{
    public PhaseCount? PhaseCount { get; set; }
    public MeasureReverseEnergy? MeasureReverseEnergy { get; set; }
}

public record MeasureReverseEnergy
{
    public Toggle Enabled { get; set; }
}

public record SensorSet
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public object? Settings { get; set; }
}
