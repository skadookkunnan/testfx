﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DataRowTestProject
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DerivedClass : BaseClass
    {
        [TestMethod]
        [DataRow("DerivedString1")]
        [DataRow("DerivedString2")]
        public override void DataRowTestMethod(string a)
        {
            Assert.IsTrue(true);
        }
    }
}
