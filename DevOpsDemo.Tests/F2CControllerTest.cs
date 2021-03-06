// <copyright file="F2CControllerTest.cs">Copyright ©  2015</copyright>
using System;
using System.Collections.Generic;
using AngularJSWebApiEmpty.Controllers;
using AngularJSWebApiEmpty.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngularJSWebApiEmpty.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for F2CController</summary>
    [PexClass(typeof(F2CController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class F2CControllerTest
    {
        /// <summary>Test stub for Delete(Int32)</summary>
        [PexMethod]
        public void DeleteTest([PexAssumeUnderTest]F2CController target, int id)
        {
            target.Delete(id);
            // TODO: add assertions to method F2CControllerTest.DeleteTest(F2CController, Int32)
        }

        /// <summary>Test stub for Get()</summary>
        [PexMethod]
        public IEnumerable<string> GetTest([PexAssumeUnderTest]F2CController target)
        {
            IEnumerable<string> result = target.Get();
            return result;
            // TODO: add assertions to method F2CControllerTest.GetTest(F2CController)
        }

        /// <summary>Test stub for Get(Int32)</summary>
        [PexMethod]
        public result GetTest01([PexAssumeUnderTest]F2CController target, int fValue)
        {
            result result = target.Get(fValue);
            return result;
            // TODO: add assertions to method F2CControllerTest.GetTest01(F2CController, Int32)
        }

        /// <summary>Test stub for Post(String)</summary>
        [PexMethod]
        public void PostTest([PexAssumeUnderTest]F2CController target, string value)
        {
            target.Post(value);
            // TODO: add assertions to method F2CControllerTest.PostTest(F2CController, String)
        }

        /// <summary>Test stub for Put(Int32, String)</summary>
        [PexMethod]
        public void PutTest(
            [PexAssumeUnderTest]F2CController target,
            int id,
            string value
        )
        {
            target.Put(id, value);
            // TODO: add assertions to method F2CControllerTest.PutTest(F2CController, Int32, String)
        }
    }
}
