using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM.Admin
{
    public partial class CreateProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Model.Process p = new Model.Process() { Name = Name.Text };

                BLL.Process.ProcessLogic pl = new BLL.Process.ProcessLogic();
                int res = pl.CreateProcess(p);
                if (res > 0)
                {
                    // Server.TransferRequest("../About.aspx", true);
                    Response.Redirect("/Admin");
                }
            }

        }
    }
}