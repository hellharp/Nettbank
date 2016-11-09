using System.Web.Mvc;
// <copyright file="KundeControllerTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nettbank.Controllers;

namespace Nettbank.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(KundeController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class KundeControllerTest
    {

        [PexMethod]
        public ActionResult TestOpprett([PexAssumeUnderTest]KundeController target)
        {
            ActionResult result = target.TestOpprett();
            return result;
            // TODO: add assertions to method KundeControllerTest.TestOpprett(KundeController)
        }
    }
}
