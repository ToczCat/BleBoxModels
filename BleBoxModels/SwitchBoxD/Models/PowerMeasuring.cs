using BleBoxModels.Common.Enums;

namespace BleBoxModels.SwitchBoxD.Models;

public record PowerMeasuring
{
    public Toggle Enabled { get; set; }
    public PowerConsumption[]? PowerConsumption { get; set; }
}

public record PowerConsumption
{
    public int PeriodS { get; set; }
    public double Value { get; set; }
}
