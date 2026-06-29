using BleBoxModels.SwitchBox.Enums;
using System.Text.Json.Serialization;

namespace BleBoxModels.SwitchBox.Models;

public record Relay
{
    [JsonPropertyName("relay")]
    public int RelayId { get; set; }

    public RelayState State { get; set; }
}
