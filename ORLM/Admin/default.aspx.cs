﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM.Admin
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Process.ProcessLogic pl = new BLL.Process.ProcessLogic();

            DropDownList1.DataSource = pl.GetAllProcesses();
            DropDownList1.DataBind();

        }
    }
}