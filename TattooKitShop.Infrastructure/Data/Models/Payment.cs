using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TattooKitShop.Infrastructure.Data.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order? Order { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaymentAmount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public DataConstants.PaymentMethod PaymentMethod { get; set; }

        [StringLength(DataConstants.Payment.CardNumberMaxLength)]
        public string CardNumber { get; set; } = null!;

        public DateTime ExpireDate { get; set;}

        [StringLength(DataConstants.Payment.SecurityNumberMaxLength)]
        public string SecurityNumber { get; set; } = null!;


        public DataConstants.PaymentStatus PaymentStatus { get; set; }
    }
}
