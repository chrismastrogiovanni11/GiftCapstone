using ChrisGiftCapstone.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChrisGiftCapstone.Startup))]
namespace ChrisGiftCapstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }

        private void CreateRolesandUsers()
        {
            ApplicationDbContext Dbcontext = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(Dbcontext));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(Dbcontext));


            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "Chris";
                user.Email = "chrismaastro@gmail.com";

                string userPWD = "C@243208!";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Manager role    
            if (!roleManager.RoleExists("Gifter"))
            {
                var role = new IdentityRole();
                role.Name = "Gifter";
                roleManager.Create(role);

            }

        }
    }
}
