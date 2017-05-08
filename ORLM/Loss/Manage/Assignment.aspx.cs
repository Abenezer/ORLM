using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM.Loss
{
    public partial class Assignment : System.Web.UI.Page
    {
        BLL.CaseLogic caseLogic;
        BLL.StaffLogic stafLogic;
        public Assignment()
        {
            caseLogic = new BLL.CaseLogic();
            stafLogic = new BLL.StaffLogic();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DateField.Text = DateTime.Today.ToShortDateString();
            DateField.DataBind();
            int pid = stafLogic.getProcessFromUserID(User.Identity.GetUserId());
         
            ProcessLabel.Text = new BLL.Process.ProcessLogic().GetProcess(pid).Name;

            if (!IsPostBack)
            {
                BranchDropList.DataSource = caseLogic.GetBranches();
                  BranchDropList.DataBind();

                CasesDropList.DataSource = caseLogic.GetUnssingedCases();
                CasesDropList.DataBind();

                PSODropList.DataSource = stafLogic.getByRoles("PSO");
                PSODropList.DataBind();
            }

       
    }

    protected void assignBtn_Click(object sender, EventArgs e)
        {
           int res = caseLogic.AssignCase(new Model.CaseAssignment {
                case_id = int.Parse(CasesDropList.SelectedItem.Value),
                staff_id = int.Parse(PSODropList.SelectedItem.Value),
                assigned_date = DateTime.Parse(DateField.Text)
                             

            });

            if(res>0)
            {
                Server.Transfer("default.aspx",true);

            }

        }

        protected void BranchDropList_SelectedIndexChanged(object sender, EventArgs e)
        {
           int branch = int.Parse(BranchDropList.SelectedItem.Value);
            CasesDropList.DataSource = caseLogic.GetByBranches(branch);
            CasesDropList.DataBind();

        }
    }
}