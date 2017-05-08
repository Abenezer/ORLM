using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORLM.Model;

namespace ORLM.BLL
{
   



   public class StaffLogic
    {

        DAL.ORLMDataSetTableAdapters.StaffsTableAdapter sta;
        DAL.ORLMDataSetTableAdapters.RoleTableAdapter rta; 
        

        public StaffLogic ()
        {
            sta = new DAL.ORLMDataSetTableAdapters.StaffsTableAdapter();
            rta = new DAL.ORLMDataSetTableAdapters.RoleTableAdapter();
        }

        public Model.Staff getStaff(int id)
        {
            return sta.GetDataByID(id).Select(s => new Model.Staff {

                FName = s.FName,
                LName = s.LName,
                Email = s.Email,
                ID = s.ID,
                PhoneNumber = s.Phone_Number,
                Title = s.Title,
                ProcessID = s.process_id,
                role_id = s.role_claim,
                UserId = s.user_id
              


            }).FirstOrDefault();
        }

        public Model.Staff getStaffFromUserID(string user_id)
        {
            return sta.GetDataByUserid(user_id).Select(s => new Model.Staff
            {

                FName = s.FName,
                LName = s.LName,
                Email = s.Email,
                ID = s.ID,
                PhoneNumber = s.Phone_Number,
                Title = s.Title,
                ProcessID = s.process_id,
                role_id = s.role_claim,
                UserId = s.user_id,
                isVerified = s.isVerified
                



            }).FirstOrDefault();

        }

        public IEnumerable<Staff> getPendingStaffs()
        {



            return sta.GetPending().Select(s => new Model.Staff {
                ID = s.ID,
                FName = s.FName,
                LName = s.LName,
                Email = s.Email,
                ProcessID =s.process_id,
                Title = s.Title

            }
         );
        }


        public IEnumerable<Staff> getByRoles(string role)
        {
            return sta.GetDataByRole(role).Select(s => new Model.Staff
            {
                ID = s.ID,
                FName = s.FName,
                LName = s.LName,
        
            }
         );

        }

        

        public int RegisterStaff(Model.Staff staff)
        {
           return  sta.InsertQuery(staff.FName, staff.LName, staff.PhoneNumber, staff.Email, staff.ProcessID,staff.UserId,false,staff.role_id);
        }


        public IEnumerable<Model.Role> getRoles ()
        {
            return rta.GetData().Select(r => new Model.Role {
                ID = r.Id,
                Name = r.Name
            }); 
        }

        public void verifyStaff(int id)
        {
            sta.VerifyStaff(id);
        }


        public int getProcessFromUserID(string user_id) 
        {
            var staff = sta.GetDataByUserid(user_id);
          if (staff.Count()>0)
            {
                return staff[0].process_id;
            }

          else
            {
                throw new  KeyNotFoundException();
            }
        }
    }
}
