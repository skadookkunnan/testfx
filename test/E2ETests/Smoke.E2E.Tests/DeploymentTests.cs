﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MSTestAdapter.Smoke.E2ETests
{
    using Microsoft.MSTestV2.CLIAutomation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DeploymentTests : CLITestBase
    {
        private const string TestAssembly = "DeploymentTestProject.dll";
        private const string RunSetting =
             @"<RunSettings>   
                <MSTestV2>
                   <DeployTestSourceDependencies>false</DeployTestSourceDependencies>
                </MSTestV2>
            </RunSettings>";

        [TestMethod]
        public void ValidateTestSourceDependencyDeployment()
        {
            this.InvokeVsTestForExecution(new string[] { TestAssembly });
            this.ValidatePassedTestsContain("DeploymentTestProject.UnitTest1.FailIfFilePresent", "DeploymentTestProject.UnitTest1.PassIfDeclaredFilesPresent");
            this.ValidateFailedTestsContain("DeploymentTestProject.dll", "DeploymentTestProject.UnitTest1.PassIfFilePresent");
        }

        [TestMethod]
        public void ValidateTestSourceLocationDeployment()
        {
            this.InvokeVsTestForExecution(new string[] { TestAssembly }, RunSetting);
            this.ValidatePassedTestsContain("DeploymentTestProject.UnitTest1.PassIfFilePresent", "DeploymentTestProject.UnitTest1.PassIfDeclaredFilesPresent");
            this.ValidateFailedTestsContain("DeploymentTestProject.dll", "DeploymentTestProject.UnitTest1.FailIfFilePresent");
        }
    }
}
