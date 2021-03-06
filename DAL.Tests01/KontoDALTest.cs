using Model;
// <copyright file="KontoDALTest.cs">Copyright ©  2016</copyright>

using System;
using DAL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Tests
{
    [TestClass]
    [PexClass(typeof(KontoDAL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class KontoDALTest
    {

        [PexMethod]
        public bool lagKonto(
            [PexAssumeUnderTest]KontoDAL target,
            Konto innKonto,
            int id
        )
        {
            bool result = target.lagKonto(innKonto, id);
            return result;
            // TODO: add assertions to method KontoDALTest.lagKonto(KontoDAL, Konto, Int32)
        }
    }
}
