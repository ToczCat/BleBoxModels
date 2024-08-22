using BleBoxModels.AirSensor.Enums;
using BleBoxModels.Common.Enums;

namespace BleBoxModels.AirSensor.Models;

public record AirSettings
{
    public Mounting MountingPlace { get; set; }
    public Toggle DetailedView { get; set; }
}
