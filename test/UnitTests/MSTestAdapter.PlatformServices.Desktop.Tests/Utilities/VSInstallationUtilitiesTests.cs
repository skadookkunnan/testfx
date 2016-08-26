// Copyright (c) Microsoft. All rights reserved.

namespace MSTestAdapter.PlatformServices.Desktop.UnitTests
{
    extern alias FrameworkV1;
    extern alias FrameworkV2;

    using Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices;
    using Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using Assert = FrameworkV1::Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
    using TestClass = FrameworkV1::Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute;
    using TestMethod = FrameworkV1::Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;

    [TestClass]
    public class VSInstallationUtilitiesTests
    {
        [TestMethod]
        public void CheckPortableModeRunningTest()
        {
            string path = Environment.GetEnvironmentVariable(Constants.PortableVsTestLocation);
            if (string.IsNullOrEmpty(path))
            {
                Assert.Inconclusive("This test required Portable vstest to be installed");
            }
            else
            {
                Assert.IsTrue(VSInstallationUtilities.CheckIfTestProcessIsRunningInXcopyableMode(path));
            }
        }

        [TestMethod]
        public void CheckResolutionPathsDoNotContainPrivateAssembliesPathTest()
        {
            TestSourceHost isolatedHost = new TestSourceHost();
            List<string> paths = isolatedHost.GetResolutionPaths(Assembly.GetExecutingAssembly().FullName, true);
            Assert.IsFalse(paths.Contains(Constants.PublicAssemblies) || paths.Contains(Constants.PrivateAssemblies));
        }
    }
}
