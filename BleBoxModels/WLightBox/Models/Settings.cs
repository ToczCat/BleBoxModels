using BleBoxModels.Common.Models;
using BleBoxModels.WLightBox.Enums;

namespace BleBoxModels.WLightBox.Models;

public record Settings : SettingsBase
{
    public RgbwSet? Rgbw { get; set; }
}

public record RgbwSet
{
    public ColorMode? ColorMode { get; set; }
    public OutputMode? OutputMode { get; set; }
    public PwmFrequency? PwmFreq { get; set; }
    public ButtonMode? ButtonMode { get; set; }
    public object[]? FieldsPreferences { get; set; }
}
