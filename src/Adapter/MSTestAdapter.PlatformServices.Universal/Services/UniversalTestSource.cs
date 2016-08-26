// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface;
    /// <summary>
    /// This platform service is responsible for any data or operations to validate
    /// the test sources provided to the adapter.
    /// </summary>
    public class TestSource : ITestSource
    {
        private static IEnumerable<string> executableExtensions = new HashSet<string>()
        {
             Constants.ExeExtension,
             //**Required only for store. In future if store support is needed, uncomment this. **//
             // Constants.DllExtension
        };

        private static HashSet<string> SYSTEM_ASSEMBLIES = new HashSet<string>(new string[]
      {
            "MICROSOFT.CSHARP.DLL",
            "MICROSOFT.VISUALBASIC.DLL",
            "CLRCOMPRESSION.DLL",
      });

        private const string SYSTEM_ASSEMBLY_PREFIX = "system.";

        // Well known platform assemblies.
        private static HashSet<string> platformAssemblies = new HashSet<string>(new string[] {
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.TESTFRAMEWORK.DLL",
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.TESTFRAMEWORK.EXTENSIONS.CORE.DLL",
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.CORE.DLL",
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.COMMON.DLL",
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.TESTEXECUTOR.CORE.DLL",
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.EXTENSIONS.MSAPPCONTAINERADAPTER.DLL",
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.EXTENSIONS.MSPHONEADAPTER.DLL",
            "MICROSOFT.VISUALSTUDIO.TESTPLATFORM.OBJECTMODEL.DLL",
            "VSTEST_EXECUTIONENGINE_PLATFORMBRIDGE.DLL",
            "VSTEST_EXECUTIONENGINE_PLATFORMBRIDGE.WINMD",
            "VSTEST.EXECUTIONENGINE.WINDOWSPHONE.DLL", });

        /// <summary>
        /// Gets the set of valid extensions for sources targeting this platform.
        /// </summary>
        public IEnumerable<string> ValidSourceExtensions => new List<string> { Constants.DllExtension, Constants.ExeExtension, Constants.AppxPackageExtension };

        /// <summary>
        /// Verifies if the assembly provided is referenced by the source.
        /// </summary>
        /// <param name="assemblyName"> The assembly name. </param>
        /// <param name="source"> The source. </param>
        /// <returns> True if the assembly is referenced. </returns>
        public bool IsAssemblyReferenced(AssemblyName assemblyName, string source)
        {
            // This code will get hit when Discovery happens during Run Tests.
            // Since Discovery during Discover Tests would have validated the presence of Unit Test Framework as reference,
            // no need to do validation again.
            // Simply return true.
            return true;

        }

        /// <summary>
        /// Gets the set of sources (dll's/exe's) that contain tests. If a source is a package(appx), return the file(dll/exe) that contains tests from it.
        /// </summary>
        /// <param name="sources"> Sources given to the adapter.  </param>
        /// <returns> Sources that contains tests. <see cref="IEnumerable"/>. </returns>
        public IEnumerable<string> GetTestSources(IEnumerable<string> sources)
        {
            if (ContainsAppxSource(sources))
            {
                List<string> newSources = new List<string>();
            
                var fileSearchTask = Windows.ApplicationModel.Package.Current.InstalledLocation.GetFilesAsync().AsTask();
                fileSearchTask.Wait();
                foreach (var filePath in fileSearchTask.Result)
                {
                    var fileName = filePath.Name;
                    var isExtSupported =
                        executableExtensions.Any(ext => fileName.EndsWith(ext, StringComparison.OrdinalIgnoreCase));
                    
                    if (isExtSupported && !fileName.StartsWith(SYSTEM_ASSEMBLY_PREFIX, StringComparison.OrdinalIgnoreCase)
                            && !platformAssemblies.Contains(fileName.ToUpperInvariant())
                            && !SYSTEM_ASSEMBLIES.Contains(fileName.ToUpperInvariant()))
                    {
                        //** Required only for store **//
                        //If a source package(appx) has both dll and exe files that contains tests, then add any one of them and not both. 
                        //if((fileName.EndsWith(Constants.ExeExtension) && !newSources.Contains(Path.GetFileNameWithoutExtension(fileName) + Constants.DllExtension))
                        //    || (fileName.EndsWith(Constants.DllExtension) && !newSources.Contains(Path.GetFileNameWithoutExtension(fileName) + Constants.ExeExtension)))
                        newSources.Add(fileName);
                        
                    }
                }
                return newSources;
            }

            return sources;
        }

        //Checks if given list of sources contains any ".appx" source.
        private bool ContainsAppxSource(IEnumerable<string> sources)
        {
            foreach (string source in sources)
            {
                if (string.Compare(Path.GetExtension(source), Constants.AppxPackageExtension , StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
