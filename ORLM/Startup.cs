using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using ORLM.Models;
using Owin;

[assembly: OwinStartup(typeof(ORLM.Startup))]
namespace ORLM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("RM"))
            {

                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "RM";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "aben";
                user.Email = "aben@gmail.com";
               string userPWD = "Password1!";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "RM");

                }
            }

            // creating Creating Manager role    
            if (!roleManager.RoleExists("RE"))
            {
                var role = new IdentityRole();
                role.Name = "RE";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("PO"))
            {
                var role = new IdentityRole();
                role.Name = "PO";
                roleManager.Create(role);

            }

            // creating Creating Employee role    
            if (!roleManager.RoleExists("PSO"))
            {
                var role = new IdentityRole();
                role.Name = "PSO";
                roleManager.Create(role);

            }
        }

    }
}
