using System.ComponentModel.DataAnnotations;

namespace dark_roasted_coffee_api.Models
{
    public class Thumbnail
    {
        [Required]
        public Large large { get; set; }
    }
}
