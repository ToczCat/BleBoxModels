using BleBoxModels.AirSensor.Enums;

namespace BleBoxModels.AirSensor.Models;

public record SensorApi
{
    public Geolocation MakeGeolocationCoarse {  get; set; }
}
