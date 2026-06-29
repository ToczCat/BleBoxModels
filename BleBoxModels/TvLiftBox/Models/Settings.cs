using BleBoxModels.Common.Models;
using BleBoxModels.TvLiftBox.Enums;

namespace BleBoxModels.TvLiftBox.Models;

public record Settings : SettingsBase
{
    public TvLiftSet? TvLift { get; set; }
}

public record TvLiftSet
{
    public ControlType? ControlType { get; set; }
    public object[]? FieldsPreferences { get; set; }
}
