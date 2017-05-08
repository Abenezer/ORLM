using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORLM.Model
{
   public class Case
    {
        public int ID { get; set; }
        public int Branch_id { get; set; }

        public string  Title { get; set; }

        public int Type_id { get; set; }

        public int Process_id { get; set; }
    }
}
