using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
using JsonConverterAttribute = System.Text.Json.Serialization.JsonConverterAttribute;

namespace dark_roasted_coffee_api.data.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FormCode
    {
        [EnumMember(Value = "Single")]
        Single = 1,
        
        [EnumMember(Value = "Hot")]
        Hot = 2,
        
        [EnumMember(Value = "Iced")]
        Iced = 3,
        
        [EnumMember(Value = "Packaged")]
        Packaged = 4,
        
        [EnumMember(Value = "Whole-Bean")]
        WholeBean = 5,
        
        [EnumMember(Value = "VIA")]
        VIA = 6,
    }
}
