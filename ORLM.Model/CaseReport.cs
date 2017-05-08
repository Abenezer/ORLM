using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORLM.Model
{
   public class CaseReport
    {
        public int ID { get; set; }

        public int loss_typeid { get; set; }
        public double Amount { get; set; }

        public bool Recovered { get; set; }

        public System.DateTime LossDate { get; set; }

        public  System.DateTime RecorededDate { get; set; }

        public string Cause { get; set; }

        public string Description { get; set; }

    }
}
