using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORLM.BLL
{
   



   public class StaffLogic
    {

        DAL.ORLMDataSetTableAdapters.StaffTableAdapter sta;
        DAL.ORLMDataSetTableAdapters.RoleTableAdapter rta; 


        public StaffLogic ()
        {
            sta = new DAL.ORLMDataSetTableAdapters.StaffTableAdapter();
            rta = new DAL.ORLMDataSetTableAdapters.RoleTableAdapter();
        }

        public int RegisterStaff(Model.Staff staff)
        {
           return  sta.Insert(staff.FName, staff.LName, staff.PhoneNumber, staff.Email, staff.ProcessID,staff.UserId,false);
        }


        public IEnumerable<String> getRoles ()
        {
            return rta.GetData().Select(r => r.Name); 
        }
    }
}
