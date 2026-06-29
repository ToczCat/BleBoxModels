using BleBoxModels.ThermoBox.Enums;

namespace BleBoxModels.ThermoBox.Models;

public record Thermo
{
    public RegulatorState? State { get; set; }
    public OperatingState? OperatingState { get; set; }
    public int DesiredTemp { get; set; }
    public Safety? Safety { get; set; }
    public Sensor[]? Sensors { get; set; }
}

public record Safety
{
    public EventReason? EventReason { get; set; }
    public TriggeredEvent[]? Triggered { get; set; }
}
