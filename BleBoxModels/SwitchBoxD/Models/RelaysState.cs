namespace BleBoxModels.SwitchBoxD.Models;

public record RelaysState
{
    public Relay[]? Relays { get; set; }
}

public record RelaysExtendedState : RelaysState
{
    public new RelayExtended[]? Relays { get; set; }
    public PowerMeasuring? PowerMeasuring { get; set; }
    public Sensor[]? Sensors { get; set; }
}
