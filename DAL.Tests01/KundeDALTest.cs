// <copyright file="KundeDALTest.cs">Copyright ©  2016</copyright>

using System;
using DAL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Tests
{
    [TestClass]
    [PexClass(typeof(KundeDAL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class KundeDALTest
    {

        [PexMethod]
        public bool slettKunde([PexAssumeUnderTest]KundeDAL target, int kID)
        {
            bool result = target.slettKunde(kID);
            return result;
            // TODO: add assertions to method KundeDALTest.slettKunde(KundeDAL, Int32)
        }
    }
}
