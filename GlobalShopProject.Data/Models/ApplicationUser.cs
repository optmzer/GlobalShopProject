using Microsoft.AspNetCore.Identity;
using System;

namespace GlobalShopProject.Data.Models
{
    public class ApplicationUser: IdentityUser
    {
        public int Rating { get; set; } = 0;
        public string ProfileImgUrl { get; set; } = "/images/default-profile-image.png";
        public DateTime MemberSince { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public string Motto { get; set; } = "Please tell us a few words about yourself";
    }
}
