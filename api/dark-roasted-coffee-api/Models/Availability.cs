using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
using JsonConverterAttribute = System.Text.Json.Serialization.JsonConverterAttribute;

namespace dark_roasted_coffee_api.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Availability
    {
        [EnumMember(Value = "Available")]
        Available = 1
    }
}
