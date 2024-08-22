using BleBoxModels.Common.Models;

namespace BleBoxModels.AirSensor.Models;

public record Settings : SettingsBase
{
    public SensorApi? SensorApi { get; set; }
    public AirSettings? Air { get; set; }
}
