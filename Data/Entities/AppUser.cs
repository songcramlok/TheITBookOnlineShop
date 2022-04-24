using System;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities
{
    public class AppUser:IdentityUser{
        public string FullName { get; set; }   
        public string Username { get; set; }   
        public string Password { get; set; }   
    }
    
}