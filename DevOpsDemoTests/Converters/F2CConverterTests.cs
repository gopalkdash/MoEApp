using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngularJSWebApiEmpty.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSWebApiEmpty.Converters.Tests
{
    [TestClass()]
    public class F2CConverterTests
    {
        private readonly F2CConverter _conv;

        public F2CConverterTests()
        {
            _conv = new F2CConverter();
        }

        [TestMethod()]
        public void F2CTest()
        {
            Assert.IsTrue(0 == _conv.F2C(32));
        }
    }
}