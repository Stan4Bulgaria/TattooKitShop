using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TattooKitShop.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(DataConstants.Review.CommentMaxLength)]
        public string Comment { get; set; } = null!;

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }

        [Required]
        public bool Recommendation { get; set; }

    }
}
