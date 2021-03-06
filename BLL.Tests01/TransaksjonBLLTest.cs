// <copyright file="TransaksjonBLLTest.cs">Copyright ©  2016</copyright>

using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    [TestClass]
    [PexClass(typeof(TransaksjonBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TransaksjonBLLTest
    {

        [PexMethod]
        public bool slettTransaksjon([PexAssumeUnderTest]TransaksjonBLL target, int tID)
        {
            bool result = target.slettTransaksjon(tID);
            return result;
            // TODO: add assertions to method TransaksjonBLLTest.slettTransaksjon(TransaksjonBLL, Int32)
        }
    }
}
