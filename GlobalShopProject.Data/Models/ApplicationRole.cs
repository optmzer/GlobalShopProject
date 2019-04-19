using Microsoft.AspNetCore.Identity;
using System;

namespace GlobalShopProject.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string roleDescription): base(roleName)
        {
            this.RoleDescription = roleDescription;
        }

        public string RoleDescription { get; set; } = "Description Was Not Provided";
        public DateTime RoleCreationDate { get; set; } = DateTime.Now;
    }
}
