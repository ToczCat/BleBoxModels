using BleBoxModels.TvLiftBox.Enums;

namespace BleBoxModels.TvLiftBox.Models;

public record TvLiftExtended : TvLift
{
    public ControlType? ControlType { get; set; }
}
