namespace BleBoxModels.MultiSensor.Enums;

public enum ComfortZone
{
    AllFine = 0,
    TooLowHumidity,
    TooHighHumidity,
    TooLowTemperature,
    TooHighTemperature,
    TooLowTemperatureAndHumidity,
    TooHighTemperatureAndHumidity,
    TooHighTemperatureTooLowHumidity,
    TooLowTemperatureTooHighHumidity
}
