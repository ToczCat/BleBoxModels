using BleBoxModels.DisplayBox.Enums;

namespace BleBoxModels.DisplayBox.Models;

public record DisplayBoxExtended : DisplayBox
{
    public LockMode DisplayLockMode { get; set; }
    public int DisplayPanelsCount { get; set; }
}
