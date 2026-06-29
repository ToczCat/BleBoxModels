using System.Text.Json.Serialization;
using BleBoxModels.SwitchBoxD.Enums;

namespace BleBoxModels.SwitchBoxD.Models;

public record Relay
{
    [JsonPropertyName("relay")]
    public int RelayNumber { get; set; }
    public RelayState State { get; set; }
}
