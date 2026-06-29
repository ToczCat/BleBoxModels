using BleBoxModels.Common.Enums;
using BleBoxModels.ThermoBox.Enums;

namespace BleBoxModels.ThermoBox.Models;

public record ThermoExtended : Thermo
{
    public Mode? Mode { get; set; }
    public int MaximumTemp { get; set; }
    public int MinimumTemp { get; set; }
    public SafetyTempSensor? SafetyTempSensor { get; set; }
    public PowerMeasuring? PowerMeasuring { get; set; }
}

public record SafetyTempSensor
{
    public int? SensorId { get; set; }
}

public record PowerMeasuring
{
    public Toggle Enabled { get; set; }
}
