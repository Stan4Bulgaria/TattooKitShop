using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TattooKitShop.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(DataConstants.ApplicationUser.UserNameMaxLength)]
        public string ApplicationUserName { get; set; } = null!;

        [Url]
        public string ProfilePicture { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public  ICollection<Review> Reviews { get; set; } = new List<Review>();

        public ICollection<Order> MyOrders { get; set; } = new List<Order>();

    }
}
