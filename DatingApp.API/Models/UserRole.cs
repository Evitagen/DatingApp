using Microsoft.AspNetCore.Identity;

namespace DatingApp.API.Models
{
    public class UserRole : IdentityUserRole<int>
    {
        public virtual user User { get; set; }
        public virtual Role Role{ get; set; }
    }
}