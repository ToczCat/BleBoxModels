using BleBoxModels.Common.Models;

namespace BleBoxModels.TempSensor.Models;

public record Settings : SettingsBase
{
    public TempSensorSettings? TempSensor { get; set; }
}
