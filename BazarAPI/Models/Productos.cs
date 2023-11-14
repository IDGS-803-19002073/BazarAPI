using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BazarAPI.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal DiscountPercentage { get; set; }

        [Column(TypeName = "decimal(3, 2)")]
        public decimal Rating { get; set; }

        public int Stock { get; set; }

        [MaxLength(100)]
        public string Brand { get; set; }

        [MaxLength(100)]
        public string Category { get; set; }

        public string Thumbnail { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}
