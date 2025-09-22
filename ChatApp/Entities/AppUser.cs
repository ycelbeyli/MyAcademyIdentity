﻿using Microsoft.AspNetCore.Identity;

namespace ChatApp.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Message> SendMessages {get;set;}
        public ICollection<Message> ReceivedMessages {get;set;}
    }
}
