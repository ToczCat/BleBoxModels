using BleBoxModels.DisplayBox.Enums;

namespace BleBoxModels.DisplayBox.Models;

public record DisplayBox
{
    public AwakeState DisplayAwakeState { get; set; }
    public LockState DisplayLockState { get; set; }
}
