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
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Process.ProcessLogic pl = new BLL.Process.ProcessLogic();

            Process.DataSource = pl.GetAllProcesses();
            


        }
    }
}