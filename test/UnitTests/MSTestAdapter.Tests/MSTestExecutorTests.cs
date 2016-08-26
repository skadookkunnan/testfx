// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MSTestExecutorTests.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.TestPlatform.MSTestAdapter.UnitTests
{
    using Moq;
    using MSTest.TestAdapter;
    using MSTest.TestAdapter.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.Execution;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using TestPlatform.ObjectModel.Adapter;

    [TestClass]
    public class MSTestExecutorTests
    {
        private Mock<IRunContext> mockRunContext;
        private Mock<IRunSettings> mockRunSettings;
        private Mock<IFrameworkHandle> mockFrameworkHandle;
        private MSTestExecutor MSTestExecutor { get; set; }

        [TestInitialize]
        public void TestInit()
        {
            this.mockRunContext = new Mock<IRunContext>();
            this.mockRunSettings = new Mock<IRunSettings>();
            this.mockFrameworkHandle = new Mock<IFrameworkHandle>();
            MSTestExecutor = new MSTestExecutor();
        }

        [TestMethod]
        public void MSTestExecutorShouldProvideTestExecutionUri()
        {
            var mstestExecutor = new MSTestExecutor();

            var extensionUriString =
                mstestExecutor.GetType().GetCustomAttributes(typeof(ExtensionUriAttribute), false).Single() as
                ExtensionUriAttribute;

            Assert.AreEqual<string>(MSTest.TestAdapter.Constants.ExecutorUriString, extensionUriString.ExtensionUri);
        }

        [TestMethod]
        public void RunTestsShouldNotExecuteTestsIfTestSettingsIsGiven()
        {
            var testCase = new TestCase("DummyName", new Uri("executor://MSTestAdapter/v2"), "DummySource");
            TestCase[] tests = new[] { testCase };
            string runSettingxml =
            @"<RunSettings>   
			        <MSTest>   
				        <SettingsFile>DummyPath\\TestSettings1.testsettings</SettingsFile>
				        <ForcedLegacyMode>true</ForcedLegacyMode>    
				        <IgnoreTestImpact>true</IgnoreTestImpact>  
			        </MSTest>
		    </RunSettings>";
            this.mockRunContext.Setup(dc => dc.RunSettings).Returns(this.mockRunSettings.Object);
            this.mockRunSettings.Setup(rs => rs.SettingsXml).Returns(runSettingxml);
            this.MSTestExecutor.RunTests(tests, this.mockRunContext.Object, this.mockFrameworkHandle.Object);

            //Test should not start if TestSettings is given.
            this.mockFrameworkHandle.Verify(fh => fh.RecordStart(tests[0]), Times.Never);
        }

        [TestMethod]
        public void RunTestsWithSourcesShouldNotExecuteTestsIfTestSettingsIsGiven()
        {
            var sources = new List<string> { Assembly.GetExecutingAssembly().Location };
            var testCase = new TestCase("DummyName", new Uri("executor://MSTestAdapter/v2"), "DummySource");
            string runSettingxml =
            @"<RunSettings>   
			        <MSTest>   
				        <SettingsFile>DummyPath\\TestSettings1.testsettings</SettingsFile>
				        <ForcedLegacyMode>true</ForcedLegacyMode>    
				        <IgnoreTestImpact>true</IgnoreTestImpact>  
			        </MSTest>
		    </RunSettings>";
            this.mockRunContext.Setup(dc => dc.RunSettings).Returns(this.mockRunSettings.Object);
            this.mockRunSettings.Setup(rs => rs.SettingsXml).Returns(runSettingxml);
            this.MSTestExecutor.RunTests(sources, this.mockRunContext.Object, this.mockFrameworkHandle.Object);

            //Test should not start if TestSettings is given.
            this.mockFrameworkHandle.Verify(fh => fh.RecordStart(testCase), Times.Never);
        }
    }
}
