using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM.Loss
{
    public partial class Identification : System.Web.UI.Page
    {
        BLL.CaseLogic caseLogic;
        BLL.StaffLogic staffLogic;
        public Identification()
        {
            caseLogic = new BLL.CaseLogic();
            staffLogic = new BLL.StaffLogic();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CaseTypeDD.DataSource = caseLogic.GetCaseTypes();
                CaseTypeDD.DataBind();

                BranchDropList.DataSource = caseLogic.GetBranches();
                BranchDropList.DataBind();
            }

        }

        protected void createBtn_Click(object sender, EventArgs e)
        {

            if(IsValid)
            {


                Model.Case c = new Model.Case()
                {
                    Branch_id = int.Parse(BranchDropList.SelectedItem.Value),
                    Title = TitleTB.Text,
                    Type_id = int.Parse(CaseTypeDD.SelectedItem.Value)
                };

               
                    var uid = HttpContext.Current.User.Identity.GetUserId();
                    c.Process_id = staffLogic.getProcessFromUserID(uid);

              if(caseLogic.CreateCase(c)>0)
                {
                    Server.Transfer("default.aspx");
                }
                
            }

        }
    }
}