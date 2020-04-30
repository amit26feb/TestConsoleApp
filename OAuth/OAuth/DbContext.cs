using Microsoft.AspNet.Identity.EntityFramework;

namespace OAuth
{
    public class OwinAuthDbContext : IdentityDbContext
    {
        public OwinAuthDbContext()
            : base("OwinAuthDbContext")
        {
        }
    }
}



