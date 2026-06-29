using BleBoxModels.ButtonBox.Enums;

namespace BleBoxModels.ButtonBox.Models;

public record ButtonboxExtended : Buttonbox
{
    public ButtonboxConfig? Buttonbox { get; set; }
}

public record ButtonboxConfig
{
    public UiType? UiType { get; set; }
}
