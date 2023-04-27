using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
using JsonConverterAttribute = System.Text.Json.Serialization.JsonConverterAttribute;

namespace dark_roasted_coffee_api.Models
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SizeCode
    {
        [EnumMember(Value = "Small")]
        Small = 1,

        [EnumMember(Value = "Medium")]
        Medium = 2,

        [EnumMember(Value = "Large")]
        Large = 3,

        [EnumMember(Value = "Single")]
        Single = 4,

        [EnumMember(Value = "Double")]
        Double = 5,

        [EnumMember(Value = "Triple")]
        Triple = 6,

        [EnumMember(Value = "Quad")]
        Quad = 7,

        [EnumMember(Value = "Kids")]
        Kids = 8,

        [EnumMember(Value = "Trenta")]
        Trenta = 9,

        [EnumMember(Value = "14.5-Packaged")]
        _145Packaged = 10,

        [EnumMember(Value = "12-Packaged")]
        _12Packaged = 11,

        [EnumMember(Value = "11-Packaged")]
        _11Packaged = 12,

        [EnumMember(Value = "8-Packaged")]
        _8Packaged = 13,

        [EnumMember(Value = "16.9-Packaged")]
        _169Packaged = 14,

        [EnumMember(Value = "20-Packaged")]
        _20Packaged = 15,

        [EnumMember(Value = "23.7-Packaged")]
        _237Packaged = 16,

        [EnumMember(Value = "600-Packaged")]
        _600Packaged = 17,

        [EnumMember(Value = "1 Piece")]
        _1Piece = 18,

        [EnumMember(Value = "8.8-oz")]
        _88Oz = 19,

        [EnumMember(Value = "1-lb")]
        _1Lb = 20,

        [EnumMember(Value = "5-count")]
        _5Count = 21,

        [EnumMember(Value = "12-count")]
        _12Count = 22,

        [EnumMember(Value = "Short")]
        Short = 23,

        [EnumMember(Value = "Tall")]
        Tall = 24,

        [EnumMember(Value = "Grande")]
        Grande = 25,

        [EnumMember(Value = "Venti")]
        Venti = 26
    }
}
