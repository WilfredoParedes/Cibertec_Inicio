using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Views.Account
{
    class WebUserDbContext: IdentityDbContext<WebDeveloperUser>
    {
        public WebUserDbContext(): base("IdentityConnectionString")
        {

        }
    }

    public class WebDeveloperUser : IdentityUser { }
}
