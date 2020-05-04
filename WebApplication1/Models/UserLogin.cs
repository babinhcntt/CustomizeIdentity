using Microsoft.AspNetCore.Identity;
namespace WebApplication1.Models
{   
    public class UserLogin: IdentityUserLogin<string>
    {
        public virtual User User { get; set; }
    }
}
