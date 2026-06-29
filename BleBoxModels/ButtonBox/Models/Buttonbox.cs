using System.Text.Json.Serialization;
using BleBoxModels.ButtonBox.Enums;

namespace BleBoxModels.ButtonBox.Models;

public record Buttonbox
{
    public Input[]? Inputs { get; set; }
}

public record Input
{
    [JsonPropertyName("input")]
    public int InputId { get; set; }
    public InputState State { get; set; }
}
