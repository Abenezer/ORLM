using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM.Loss
{
    public partial class Recored : System.Web.UI.Page
    {
        BLL.CaseLogic caseLogic;
        BLL.StaffLogic staffLogic;

        public Recored ()
        {
            caseLogic = new BLL.CaseLogic();
            staffLogic = new BLL.StaffLogic();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string user_id = User.Identity.GetUserId();
            int staff_id = staffLogic.getStaffFromUserID(user_id).ID;

            CheckBoxRecovered.InputAttributes.Add("data-toggle", "toggle");
            if(!IsPostBack)
            {
                CasesDropList.DataSource = caseLogic.getAssignedCases(staff_id);
                CasesDropList.DataBind();

                LossTypeDropList.DataSource = caseLogic.getLossTypes();
                LossTypeDropList.DataBind();

                BranchDropList.DataSource = caseLogic.GetBranches();
                BranchDropList.DataBind();



            }

        }

        protected void ReportBtn_Click(object sender, EventArgs e)
        {

            Model.CaseReport report = new Model.CaseReport {
                ID = int.Parse(CasesDropList.SelectedItem.Value),
                Amount = double.Parse(TextBoxAmount.Text),
                Description = TextBoxDescription.Text,
                Cause =TextBoxCause.Text,
                LossDate = DateTime.Parse(DateField.Text),
                loss_typeid = int.Parse(LossTypeDropList.SelectedItem.Value),
                 RecorededDate = System.DateTime.Today,
                 Recovered = CheckBoxRecovered.Checked,

            };

           if( caseLogic.reportCase(report)>0)
            {
                Server.Transfer("~/default.aspx", true);
            }
           

        }

        protected void CasesDropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int case_id = int.Parse(CasesDropList.SelectedItem.Value);


            BranchDropList.SelectedValue = caseLogic.getCaseBranch(case_id).ID.ToString();

        }
    }
}