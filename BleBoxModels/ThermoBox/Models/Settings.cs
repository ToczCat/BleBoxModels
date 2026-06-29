using BleBoxModels.Common.Models;
using BleBoxModels.ThermoBox.Enums;

namespace BleBoxModels.ThermoBox.Models;

public record Settings : SettingsBase
{
    public PowerMeasuring? PowerMeasuring { get; set; }
    public ThermoSet? Thermo { get; set; }
}

public record ThermoSet
{
    public Mode? Mode { get; set; }
    public OutputMode? OutputMode { get; set; }
    public int MinimumTemp { get; set; }
    public int MaximumTemp { get; set; }
    public int BoostTimeM { get; set; }
    public int ControlTimeS { get; set; }
    public Dictionary<string, int>? UserTempOffset { get; set; }
    public int[]? HysteresisWindow { get; set; }
    public SafetyTempSensorSet? SafetyTempSensor { get; set; }
    public object[]? FieldsPreferences { get; set; }
}

public record SafetyTempSensorSet
{
    public int? SensorId { get; set; }
    public int SafetyTemp { get; set; }
}
