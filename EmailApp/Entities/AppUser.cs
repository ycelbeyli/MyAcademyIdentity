using Microsoft.AspNetCore.Identity;

namespace EmailApp.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }
        public IList<Message> SentMessages  { get; set; }
        public IList<Message> ReceivedMessages  { get; set; }
    }
}
