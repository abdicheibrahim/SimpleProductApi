using System.ComponentModel.DataAnnotations;

namespace SimpleProductApi.DTOs
{
    public class CreateProductDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Range(0.01, 999999)]
        public decimal Price { get; set; }
    }
}
