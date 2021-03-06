using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
// <copyright file="LoggFeilTest.SkrivTilFil.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace BLL.Tests
{
    public partial class LoggFeilTest
    {

[TestMethod]
[PexGeneratedBy(typeof(LoggFeilTest))]
public void SkrivTilFil803()
{
    Exception exception;
    exception = new Exception();
    LoggFeil s0 = new LoggFeil();
    this.SkrivTilFil(s0, exception);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(LoggFeilTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void SkrivTilFilThrowsNullReferenceException914()
{
    LoggFeil s0 = new LoggFeil();
    this.SkrivTilFil(s0, (Exception)null);
}
    }
}
