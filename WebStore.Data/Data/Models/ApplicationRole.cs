using Microsoft.AspNetCore.Identity;

namespace WebStore.Infrastructure.Data.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string role) : base(role)
        {
        }
    }
}
