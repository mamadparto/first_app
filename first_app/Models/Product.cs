using System.ComponentModel.DataAnnotations;

namespace first_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public required string Name { get; set; }
        public decimal Price { get; set; }

        public string? Description { get; set; }
    }
}
