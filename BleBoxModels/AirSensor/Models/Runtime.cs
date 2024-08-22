using BleBoxModels.Common.JsonConverters;
using System.Text.Json.Serialization;

namespace BleBoxModels.AirSensor.Models;

public record Runtime
{
    [JsonConverter(typeof(IntHoursToTimeSpanConverter))]
    public TimeSpan TimeH { get; set; }
}
