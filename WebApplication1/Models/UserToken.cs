using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserToken:IdentityUserToken<string>
    {
        public virtual User User { get; set; }
    }
}
