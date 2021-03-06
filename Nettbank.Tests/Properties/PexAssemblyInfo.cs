// <copyright file="PexAssemblyInfo.cs">Copyright ©  2016</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Nettbank")]
[assembly: PexInstrumentAssembly("EntityFramework")]
[assembly: PexInstrumentAssembly("TrackerEnabledDbContext")]
[assembly: PexInstrumentAssembly("System.Web.Mvc")]
[assembly: PexInstrumentAssembly("Microsoft.CSharp")]
[assembly: PexInstrumentAssembly("System.Web.Optimization")]
[assembly: PexInstrumentAssembly("BLL")]
[assembly: PexInstrumentAssembly("System.Web")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("TrackerEnabledDbContext.Common")]
[assembly: PexInstrumentAssembly("System.ComponentModel.DataAnnotations")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "EntityFramework")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "TrackerEnabledDbContext")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Mvc")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CSharp")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Optimization")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "BLL")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "TrackerEnabledDbContext.Common")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.ComponentModel.DataAnnotations")]

