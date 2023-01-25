using Microsoft.AspNetCore.Identity;

namespace CES.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Submission> Submissions { get; set; }
    }
}