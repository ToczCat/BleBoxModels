using BleBoxModels.Common.Models;

namespace BleBoxModels.ButtonBox.Models;

public record Settings : SettingsBase
{
    public ButtonboxConfig? Buttonbox { get; set; }
}
