using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORLM.Model
{
   public class Staff
    {
        public int ID { get; set; }
        public string FName { get; set; }

        public string LName { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

       public int ProcessID { get; set; }

        public string UserId { get; set; }

        public string role_id { get; set; }
        public string FullName { get { return FName + " " + LName; } }

        public bool isVerified { get; set; }


    }
}
