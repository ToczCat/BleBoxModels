using BleBoxModels.Common.Enums;
using BleBoxModels.Common.Models;
using BleBoxModels.DisplayBox.Enums;

namespace BleBoxModels.DisplayBox.Models;

public record Settings : SettingsBase
{
    public IconSet? IconSet { get; set; }
    public SystemSounds? SystemSounds { get; set; }
    public DisplayBoxSet? DisplayBox { get; set; }
}

public record SystemSounds
{
    public SystemSoundsInterface? Interface { get; set; }
}

public record SystemSoundsInterface
{
    public Toggle Enabled { get; set; }
}

public record DisplayBoxSet
{
    public int DisplayBrightness { get; set; }
    public int DisplayIdleTimeS { get; set; }
    public LockMode DisplayLockMode { get; set; }
    public string? DisplayLockPin { get; set; }
    public DisplayPanel[]? DisplayPanels { get; set; }
    public object[]? FieldsPreferences { get; set; }
}

public record DisplayPanel
{
    public int Id { get; set; }
    public PanelType PanelType { get; set; }
    public DisplayPanelSettings? Settings { get; set; }
}

public record DisplayPanelSettings
{
    public string? Address { get; set; }
}
