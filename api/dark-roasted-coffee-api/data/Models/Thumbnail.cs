using System.ComponentModel.DataAnnotations;

namespace dark_roasted_coffee_api.data.Models
{
    public class Thumbnail
    {
        [Required]
        public Large large { get; set; }
    }
}
