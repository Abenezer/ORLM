using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        bool? _isVerified; 
        public bool UserVerified { get
            {
                if (!_isVerified.HasValue)
                { _isVerified = new BLL.StaffLogic().getStaffFromUserID(User.Identity.GetUserId()).isVerified; }
                return _isVerified.Value;
             
            } }

      public string WelcomeLabel { get
            {
                if (UserVerified)
                    return "Welcome";
                else
                    return "Please Contact the Risk Manager to verify your account";
            } }
       

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var email = (loginView.FindControl("Email") as TextBox).Text;
                var password = (loginView.FindControl("Password") as TextBox).Text;

                var result = signinManager.PasswordSignIn(email, password, true, shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        {
                            var returnUrl = "/";
                          var user_id = manager.FindByName(email).Id;
                          
                            if (manager.IsInRole(user_id, "RM"))
                            {
                                returnUrl = "/Admin";
                            }
                            else if (manager.IsInRole(user_id, "PO"))
                            {
                                returnUrl = "/Loss/Manage";
                            }

                            else if (manager.IsInRole(user_id, "PSO"))
                            {
                                returnUrl = "/";
                            }
                            IdentityHelper.RedirectToReturnUrl(returnUrl, Response);
                        }
                        
                        break;
                    case SignInStatus.LockedOut:
                        Response.Redirect("/Account/Lockout");
                        break;
                    case SignInStatus.RequiresVerification:
                        Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}",
                                                        Request.QueryString["ReturnUrl"],
                                                        true),
                                          true);
                        break;
                    case SignInStatus.Failure:
                    default:
                        //FailureText.Text = "Invalid login attempt";
                       // ErrorMessage.Visible = true;
                        break;
                }
            }

        }
    }
}