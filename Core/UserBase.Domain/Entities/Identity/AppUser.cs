using Microsoft.AspNetCore.Identity;

namespace UserBase.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? BirthDate { get; set; }
        public string ProfileImageUrl { get; set; }
    }
}
