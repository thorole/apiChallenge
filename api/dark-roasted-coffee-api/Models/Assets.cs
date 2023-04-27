using System.ComponentModel.DataAnnotations;

namespace dark_roasted_coffee_api.Models
{
    public partial class Assets
    {
        [Required]
        public Thumbnail thumbnail { get; set; }
        [Required]
        public FullSize fullSize { get; set; }
        [Required]
        public FullSize masterImage { get; set; }
    }
}

