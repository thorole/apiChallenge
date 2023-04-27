using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace dark_roasted_coffee_api.Models
{
    public partial class CoffeeDrink
    {
        [Required]
        public string Name { get; set; }

        [SwaggerSchema(Description = "how the drink will be served(i.e.the form)")]
        [Required]
        public FormCode FormCode { get; set; }

        [SwaggerSchema(Description = "the drink's relative placement in the catalog (lower number means higher up on the list)")]
        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public Availability Availability { get; set; }

        [Required]
        public Assets Assets { get; set; }

        [Required]

        public IList<SizeCode> Sizes { get; set; }
        [Required]
        public int Id { get; set; }

        [SwaggerSchema(Description = "the type of coffee drink (e.g. \"espressos\", \"cappuccinos\", etc.")]
        [Required]
        public string Category { get; set; }
    }
}
