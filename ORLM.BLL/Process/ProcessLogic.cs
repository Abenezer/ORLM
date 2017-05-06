using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORLM.BLL.Process
{
  public  class ProcessLogic
    {
        DAL.ORLMDataSetTableAdapters.ProcessTableAdapter pta;


        public ProcessLogic()
        {
            pta = new DAL.ORLMDataSetTableAdapters.ProcessTableAdapter();
        }




       public int CreateProcess (string Name)
        {
           

            return (int)(decimal) pta.InsertAndReturnID(Name);


        }

        public IEnumerable<Model.Process> GetAllProcesses()
        {
            return pta.GetData().Select(p => new Model.Process {
                ID = p.ID,
                Name = p.Name
            });
        }
        public int CreateProcess(Model.Process process)
        {


            return this.CreateProcess(process.Name);


        }
        public Model.Process GetProcess (int ID)
        {
           

            return pta.GetByID(ID).Select(p => new Model.Process
            {
                ID = p.ID,
                Name = p.Name,

            }).FirstOrDefault();
        }




    }
}
