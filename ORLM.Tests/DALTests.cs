using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ORLM.Tests
{
    [TestClass]
    public class DALTests
    {
        [TestMethod]
        public void TestCreateProcess()
        {
            DAL.ORLMDataSetTableAdapters.ProcessTableAdapter pta = new DAL.ORLMDataSetTableAdapters.ProcessTableAdapter();

            pta.Insert("Finance");




            DAL.ORLMDataSet.ProcessDataTable processes = new DAL.ORLMDataSet.ProcessDataTable();
            processes = pta.GetData();

            Assert.AreEqual(processes[0].Name, "Finance");





        }

        [TestMethod]
        public void TestCreateProessFromBLL()
        {
            BLL.Process.ProcessLogic pl = new BLL.Process.ProcessLogic();

           int id = pl.CreateProcess("HR");

            Assert.AreEqual(pl.GetProcess(id).Name, "HR");

        }


        [TestMethod]
        public void JoinTableAdabter()
        {
            DAL.ORLMDataSetTableAdapters.StaffTableAdapter sta = new DAL.ORLMDataSetTableAdapters.StaffTableAdapter();
            Assert.AreEqual(sta.GetDataByID(4)[0].Title, "PO");

        }
    }
}
