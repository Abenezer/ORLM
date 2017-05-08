using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ORLM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM.Staff
{
    public partial class Register : System.Web.UI.Page
    {
        BLL.Process.ProcessLogic pl;
        BLL.StaffLogic sl;

        public Register ()
        {
                pl = new BLL.Process.ProcessLogic();
                sl = new BLL.StaffLogic();
        }


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ProcessDD.DataSource = pl.GetAllProcesses();
                ProcessDD.DataBind();

                TitleDD.DataSource = sl.getRoles();

                TitleDD.DataBind();
            }

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
          // int x= int.Parse(ProcessDD.SelectedItem.Value);

            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                Model.Staff staff = new Model.Staff
                {
                    FName = FName.Text,
                    LName = LName.Text,
                    Email = Email.Text,
                    ProcessID = int.Parse(ProcessDD.SelectedItem.Value),
                    Title = TitleDD.SelectedItem.Text,
                    role_id = TitleDD.SelectedItem.Value,
                    PhoneNumber = Phone.Text,
                    UserId = user.Id,
                   
                };

                if (sl.RegisterStaff(staff) > 0)
                {
                    //manager.AddToRole(user.Id, staff.Title);
                    signInManager.SignIn(user, isPersistent: true, rememberBrowser: true);
                    //Server.TransferRequest("~/default.aspx");
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }

               
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }





            




        }
    }
}