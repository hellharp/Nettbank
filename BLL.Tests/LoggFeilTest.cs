// <copyright file="LoggFeilTest.cs">Copyright ©  2016</copyright>

using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    [TestClass]
    [PexClass(typeof(LoggFeil))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class LoggFeilTest
    {

        [PexMethod]
        public void SkrivTilFil([PexAssumeUnderTest]LoggFeil target, Exception feil)
        {
            target.SkrivTilFil(feil);
            // TODO: add assertions to method LoggFeilTest.SkrivTilFil(LoggFeil, Exception)
        }
    }
}
