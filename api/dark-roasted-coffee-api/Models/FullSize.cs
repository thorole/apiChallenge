using System.ComponentModel.DataAnnotations;

namespace dark_roasted_coffee_api.Models
{
    public class FullSize
    {
        [Required]
        public string uri { get; set; }
    }
}
