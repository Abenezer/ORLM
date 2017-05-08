using System;

namespace ORLM.Model
{
    public class CaseAssignment
    {
        public int case_id { get; set; }
        public int staff_id { get; set; }
        public DateTime assigned_date { get; set; }

        public string Title{ get; set; }
    }
}