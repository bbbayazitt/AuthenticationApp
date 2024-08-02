
using Microsoft.AspNetCore.Identity; //import the Microsoft.AspNetCore.Identity namespace, which provides the core user identity classes for application.
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace AuthenticationApp.Data // declares namespace for the code.
{
    public class AppDbContext : IdentityDbContext<IdentityUser> //automatically includes all the database tables and relationship needed for user authentication.
    {
        public AppDbContext(DbContextOptions<DbContext> options) :base(options) 
        { 
        
        }
    }
}
