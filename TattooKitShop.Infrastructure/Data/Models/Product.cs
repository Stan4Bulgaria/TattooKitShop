using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TattooKitShop.Infrastructure.Data.Models
{
    [Comment("Product to add")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.Product.NameMaxLength)]
        [Comment("Product name")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DataConstants.Product.DescriptionMaxLength)]
        [Comment("The description of the product")]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(DataConstants.Product.BrandMaxLength)]
        [Comment("The brand name")]
        public string Brand { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("The price of the product")]
        public decimal Price { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;


        [Comment("The amount of like a product holds")]
        public int Likes { get; set; } = 0;

        [Comment("The amount of dislikes a product holds")]
        public int Dislikes { get; set; } = 0;

        [Comment("Foreign key from Category")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }
    }
}
