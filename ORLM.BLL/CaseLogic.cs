using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORLM.BLL
{
   public class CaseLogic
    {
        DAL.ORLMDataSetTableAdapters.CaseTypeTableAdapter caseTypeTA;
        DAL.ORLMDataSetTableAdapters.CaseTableAdapter caseTA;
        DAL.ORLMDataSetTableAdapters.BranchTableAdapter branchTA;
        
        public CaseLogic ()
        {
            caseTypeTA = new DAL.ORLMDataSetTableAdapters.CaseTypeTableAdapter();
            caseTA = new DAL.ORLMDataSetTableAdapters.CaseTableAdapter();
            branchTA = new DAL.ORLMDataSetTableAdapters.BranchTableAdapter();
        }

        public IEnumerable<Model.CaseAssignment> getAssignedCases(int staff_id)
        {
            return new DAL.ORLMDataSetTableAdapters.CaseAssigmentTableAdapter().GetAssigned(staff_id).Select(c=> new Model.CaseAssignment {
                Title = c.Title,
                case_id = c.case_id
            });
                        
        }

        public object getLossTypes()
        {
            return new DAL.ORLMDataSetTableAdapters.LossTypeTableAdapter().GetData();
        }

        public IEnumerable<Model.Case> GetCases()
        {
            return caseTA.GetData().Select(c => new Model.Case
            {
                Branch_id = c.Branch_id,
                ID = c.ID,
                Process_id = c.process_id,
                Title = c.Title,
                Type_id = c.type_id
            });
        }

        public Model.Branch getCaseBranch(int case_id)
        {
            return new DAL.ORLMDataSetTableAdapters.BranchTableAdapter().GetCaseBranch(case_id).Select(b => new Model.Branch
            {
                ID = b.ID,
                Name = b.Name
            }).FirstOrDefault();
        }

        public IEnumerable<Model.Case> GetUnssingedCases()
        {
            return caseTA.GetUnassignedCases().Select(c => new Model.Case
            {
                Branch_id = c.Branch_id,
                ID = c.ID,
                Process_id = c.process_id,
                Title = c.Title,
                Type_id = c.type_id
            });
        }

        public IEnumerable<Model.CaseType> GetCaseTypes()
        {
           return caseTypeTA.GetData().Select(c => new Model.CaseType
            {
                ID = c.ID,
                Name = c.Name
            });

        }

       
       
     


        public int CreateCase(Model.Case c)
        {

            
            return caseTA.Insert(c.Title, c.Process_id, c.Branch_id, c.Type_id); 
        }


        public IEnumerable<Model.Branch> GetBranches()
        {
            return branchTA.GetData().Select(b => new Model.Branch {
                ID = b.ID,
                Name = b.Name,

            });
        }
        public IEnumerable<Model.Case> GetByBranches(int branch)
        {
          return  this.GetUnssingedCases().Where(c => c.Branch_id == branch);
        }


        public int reportCase(Model.CaseReport case_report)
        {
            DAL.ORLMDataSetTableAdapters.CaseDetailTableAdapter caseDetailTA = new DAL.ORLMDataSetTableAdapters.CaseDetailTableAdapter();

           return  caseDetailTA.Insert(case_report.ID, case_report.Description, case_report.loss_typeid, case_report.Cause, case_report.Recovered, case_report.LossDate, case_report.RecorededDate,case_report.Amount);

        }

        public int AssignCase(Model.CaseAssignment assignment)
        {
            DAL.ORLMDataSetTableAdapters.CaseAssigmentTableAdapter assignmnetTA = new DAL.ORLMDataSetTableAdapters.CaseAssigmentTableAdapter();
            return assignmnetTA.InsertQuery(assignment.case_id, assignment.staff_id, assignment.assigned_date);
        }
    }
}
