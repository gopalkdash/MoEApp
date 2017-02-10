using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngularJSWebApiEmpty.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AngularJSWebApiEmpty.Controllers.Tests
{
    [TestClass()]
    public class F2CControllerTests
    {
        private readonly AngularJSWebApiEmpty.Controllers.F2CController _ctrl;

        public F2CControllerTests()
        {
            _ctrl = new F2CController();
        }

        
        [TestMethod()]
        public void GetTest()
        {
            int result = 0;
            string c = _ctrl.Get(32).ToString();
            Assert.IsTrue(c == result.ToString());
            F2CController ctrl = new F2CController();
            //Assert.AreEqual(0, ctrl.Get(32));
        }

        [TestMethod()]
        public void GetTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}