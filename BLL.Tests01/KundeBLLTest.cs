// <copyright file="KundeBLLTest.cs">Copyright ©  2016</copyright>

using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    [TestClass]
    [PexClass(typeof(KundeBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class KundeBLLTest
    {

        [PexMethod]
        public bool slettKunde([PexAssumeUnderTest]KundeBLL target, int kID)
        {
            bool result = target.slettKunde(kID);
            return result;
            // TODO: add assertions to method KundeBLLTest.slettKunde(KundeBLL, Int32)
        }
    }
}
