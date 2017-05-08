using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ORLM.Admin
{
    public partial class ConfirmStaff : System.Web.UI.Page
    {
        BLL.Process.ProcessLogic processLogic;
        BLL.StaffLogic staffLogic;


        public ConfirmStaff ()
        {
            processLogic = new BLL.Process.ProcessLogic();
            staffLogic = new BLL.StaffLogic();

        }

     // public  IEnumerable<Model.Staff> PendingStaffs; 
        protected void Page_Load(object sender, EventArgs e)
        {
            //  this.PendingStaffs = 
          
           
            if (!IsPostBack)
            {
                ProcessDropList.DataSource = processLogic.GetAllProcesses();
                ProcessDropList.DataBind();
                PendingStaffsListView.DataSource = staffLogic.getPendingStaffs();
                PendingStaffsListView.DataBind();

            }

         

            foreach (var item in PendingStaffsListView.Items)
            {

                var toggle = item.FindControl("togglebox") as CheckBox;
                toggle.InputAttributes.Add("data-toggle", "toggle");
                toggle.InputAttributes["data-onstyle"] = "success";
                toggle.InputAttributes["data-offstyle"] = "danger";
            }

        }

        protected void ProcessDropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int proccess_id = int.Parse(ProcessDropList.SelectedItem.Value);
            PendingStaffsListView.DataSource = staffLogic.getPendingStaffs().Where(s=>s.ProcessID==proccess_id);
            PendingStaffsListView.DataBind();

        }

        protected void Approve_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();


            foreach (var item in PendingStaffsListView.Items)
            {

                var toggle = item.FindControl("togglebox") as CheckBox;
               if(toggle.Checked)
                {

                    var idField = item.FindControl("ID") as HiddenField;
                    int id = int.Parse(idField.Value);

                   staffLogic.verifyStaff(id);
                    Model.Staff staff = staffLogic.getStaff(id);
                    manager.AddToRole(staff.UserId, staff.Title);


                }
            }

        }
    }
}