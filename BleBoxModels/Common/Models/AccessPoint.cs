using BleBoxModels.Common.Enums;

namespace BleBoxModels.Common.Models;

public record AccessPoint
{
    public string? Ssid { get; set; }
    public int Rssi { get; set; }
    public EncryptionMode Enc { get; set; }
}
