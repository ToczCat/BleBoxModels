using BleBoxModels.ShutterBox.Enums;

namespace BleBoxModels.ShutterBox.Models;

public record Shutter
{
    public State State { get; set; }
    public ShutterPosition? CurrentPos { get; set; }
    public ShutterPosition? DesiredPos { get; set; }
    public ShutterPosition? FavPos { get; set; }
    public Safety? Safety { get; set; }
}

public record ShutterPosition
{
    public int Position { get; set; }
    public int Tilt { get; set; }
}

public record Safety
{
    public EventReason EventReason { get; set; }
    public EventReason[]? Triggered { get; set; }
}
