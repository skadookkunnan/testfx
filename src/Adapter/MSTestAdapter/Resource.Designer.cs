//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.Resource", typeof(Resource).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSTestAdapterV2.
        /// </summary>
        internal static string AttachmentSetDisplayName {
            get {
                return ResourceManager.GetString("AttachmentSetDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter should not be null or empty..
        /// </summary>
        internal static string Common_CannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("Common_CannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter must be greater than zero..
        /// </summary>
        internal static string Common_MustBeGreaterThanZero {
            get {
                return ResourceManager.GetString("Common_MustBeGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSTestAdapter failed to discover tests in class &apos;{0}&apos; of assembly &apos;{1}&apos; because {2}..
        /// </summary>
        internal static string CouldNotInspectTypeDuringDiscovery {
            get {
                return ResourceManager.GetString("CouldNotInspectTypeDuringDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSTestAdapter failed to discover tests in class &apos;{0}&apos; of assembly &apos;{1}&apos;. Reason {2}..
        /// </summary>
        internal static string CouldNotInspectTypeDuringDiscovery1 {
            get {
                return ResourceManager.GetString("CouldNotInspectTypeDuringDiscovery1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debug Trace:.
        /// </summary>
        internal static string DebugTraceBanner {
            get {
                return ResourceManager.GetString("DebugTraceBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: {1}.
        /// </summary>
        internal static string EnumeratorLoadTypeErrorFormat {
            get {
                return ResourceManager.GetString("EnumeratorLoadTypeErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test &apos;{0}&apos; exceeded execution timeout period..
        /// </summary>
        internal static string Execution_Test_Timeout {
            get {
                return ResourceManager.GetString("Execution_Test_Timeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running tests in any of the provided sources is not supported for the selected platform.
        /// </summary>
        internal static string SourcesNotSupported {
            get {
                return ResourceManager.GetString("SourcesNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File does not exist: {0}.
        /// </summary>
        internal static string TestAssembly_FileDoesNotExist {
            get {
                return ResourceManager.GetString("TestAssembly_FileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TestContext cannot be Null..
        /// </summary>
        internal static string TestContextIsNull {
            get {
                return ResourceManager.GetString("TestContextIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test method {0} was not found..
        /// </summary>
        internal static string TestNotFound {
            get {
                return ResourceManager.GetString("TestNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load types from the test source &apos;{0}&apos;. Some or all of the tests in this source may not be discovered..
        /// </summary>
        internal static string TypeLoadFailed {
            get {
                return ResourceManager.GetString("TypeLoadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly Cleanup method {0}.{1} failed. Error Message: {2}. StackTrace: {3}.
        /// </summary>
        internal static string UTA_AssemblyCleanupMethodWasUnsuccesful {
            get {
                return ResourceManager.GetString("UTA_AssemblyCleanupMethodWasUnsuccesful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly Initialization method {0}.{1} threw exception. {2}: {3}. Aborting test execution..
        /// </summary>
        internal static string UTA_AssemblyInitMethodThrows {
            get {
                return ResourceManager.GetString("UTA_AssemblyInitMethodThrows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class Cleanup method {0}.{1} failed. Error Message: {2}. Stack Trace: {3}.
        /// </summary>
        internal static string UTA_ClassCleanupMethodWasUnsuccesful {
            get {
                return ResourceManager.GetString("UTA_ClassCleanupMethodWasUnsuccesful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class Initialization method {0}.{1} threw exception. {2}: {3}..
        /// </summary>
        internal static string UTA_ClassInitMethodThrows {
            get {
                return ResourceManager.GetString("UTA_ClassInitMethodThrows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method {0}.{1} has wrong signature. The method must be static, public, does not return a value and should not take any parameter. Additionally, if you are using async-await in method then return-type must be Task..
        /// </summary>
        internal static string UTA_ClassOrAssemblyCleanupMethodHasWrongSignature {
            get {
                return ResourceManager.GetString("UTA_ClassOrAssemblyCleanupMethodHasWrongSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method {0}.{1} has wrong signature. The method must be static, public, does not return a value and should take a single parameter of type TestContext. Additionally, if you are using async-await in method then return-type must be Task..
        /// </summary>
        internal static string UTA_ClassOrAssemblyInitializeMethodHasWrongSignature {
            get {
                return ResourceManager.GetString("UTA_ClassOrAssemblyInitializeMethodHasWrongSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TestCleanup method {0}.{1} threw exception. {2}..
        /// </summary>
        internal static string UTA_CleanupMethodThrows {
            get {
                return ResourceManager.GetString("UTA_CleanupMethodThrows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --- End of inner exception stack trace ---.
        /// </summary>
        internal static string UTA_EndOfInnerExceptionTrace {
            get {
                return ResourceManager.GetString("UTA_EndOfInnerExceptionTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA015: A generic method cannot be a test method. {0}.{1} has invalid signature.
        /// </summary>
        internal static string UTA_ErrorGenericTestMethod {
            get {
                return ResourceManager.GetString("UTA_ErrorGenericTestMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA007: Method {1} defined in class {0} does not have correct signature. Test method marked with the [TestMethod] attribute must be non-static, public, return-type as void  and should not take any parameter. Example: public void Test.Class1.Test(). Additionally, if you are using async-await in test method then return-type must be Task. Example: public async Task Test.Class1.Test2().
        /// </summary>
        internal static string UTA_ErrorIncorrectTestMethodSignature {
            get {
                return ResourceManager.GetString("UTA_ErrorIncorrectTestMethodSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA031: class {0} does not have valid TestContext property. TestContext must be of type TestContext, must be non-static, public and must not be read-only. For example: public TestContext TestContext..
        /// </summary>
        internal static string UTA_ErrorInValidTestContextSignature {
            get {
                return ResourceManager.GetString("UTA_ErrorInValidTestContextSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA054: {0}.{1} has invalid Timeout attribute. The timeout must be a valid integer value and cannot be less than 0..
        /// </summary>
        internal static string UTA_ErrorInvalidTimeout {
            get {
                return ResourceManager.GetString("UTA_ErrorInvalidTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA014: {0}: Cannot define more than one method with the AssemblyCleanup attribute inside an assembly..
        /// </summary>
        internal static string UTA_ErrorMultiAssemblyClean {
            get {
                return ResourceManager.GetString("UTA_ErrorMultiAssemblyClean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA013: {0}: Cannot define more than one method with the AssemblyInitialize attribute inside an assembly..
        /// </summary>
        internal static string UTA_ErrorMultiAssemblyInit {
            get {
                return ResourceManager.GetString("UTA_ErrorMultiAssemblyInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA026: {0}: Cannot define more than one method with the ClassCleanup attribute inside a class..
        /// </summary>
        internal static string UTA_ErrorMultiClassClean {
            get {
                return ResourceManager.GetString("UTA_ErrorMultiClassClean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA025: {0}: Cannot define more than one method with the ClassInitialize attribute inside a class..
        /// </summary>
        internal static string UTA_ErrorMultiClassInit {
            get {
                return ResourceManager.GetString("UTA_ErrorMultiClassInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA024: {0}: Cannot define more than one method with the TestCleanup attribute..
        /// </summary>
        internal static string UTA_ErrorMultiClean {
            get {
                return ResourceManager.GetString("UTA_ErrorMultiClean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA018: {0}: Cannot define more than one method with the TestInitialize attribute..
        /// </summary>
        internal static string UTA_ErrorMultiInit {
            get {
                return ResourceManager.GetString("UTA_ErrorMultiInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA001: TestClass attribute defined on non-public class {0}.
        /// </summary>
        internal static string UTA_ErrorNonPublicTestClass {
            get {
                return ResourceManager.GetString("UTA_ErrorNonPublicTestClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA023: {0}: Cannot define predefined property {2} on method {1}..
        /// </summary>
        internal static string UTA_ErrorPredefinedTestProperty {
            get {
                return ResourceManager.GetString("UTA_ErrorPredefinedTestProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA022: {0}.{1}: The custom property &quot;{2}&quot; is already defined. Using &quot;{3}&quot; as value..
        /// </summary>
        internal static string UTA_ErrorTestPropertyAlreadyDefined {
            get {
                return ResourceManager.GetString("UTA_ErrorTestPropertyAlreadyDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTA021: {0}: Null or empty custom property defined on method {1}. The custom property must have a valid name..
        /// </summary>
        internal static string UTA_ErrorTestPropertyNullOrEmpty {
            get {
                return ResourceManager.GetString("UTA_ErrorTestPropertyNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception thrown while executing test. If using extension of TestMethodAttribute then please contact vendor. Error message: {0}.
        /// </summary>
        internal static string UTA_ExecuteThrewException {
            get {
                return ResourceManager.GetString("UTA_ExecuteThrewException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to obtain the exception thrown by test method {0}.{1}..
        /// </summary>
        internal static string UTA_FailedToGetTestMethodException {
            get {
                return ResourceManager.GetString("UTA_FailedToGetTestMethodException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialization method {0}.{1} threw exception. {2}..
        /// </summary>
        internal static string UTA_InitMethodThrows {
            get {
                return ResourceManager.GetString("UTA_InitMethodThrows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create instance of class {0}. Error: {1}..
        /// </summary>
        internal static string UTA_InstanceCreationError {
            get {
                return ResourceManager.GetString("UTA_InstanceCreationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method {0}.{1} does not exist..
        /// </summary>
        internal static string UTA_MethodDoesNotExists {
            get {
                return ResourceManager.GetString("UTA_MethodDoesNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get default constructor for class {0}..
        /// </summary>
        internal static string UTA_NoDefaultConstructor {
            get {
                return ResourceManager.GetString("UTA_NoDefaultConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in executing test. No result returned by extension. If using extension of TestMethodAttribute then please contact vendor..
        /// </summary>
        internal static string UTA_NoTestResult {
            get {
                return ResourceManager.GetString("UTA_NoTestResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find property {0}.TestContext. Error:{1}..
        /// </summary>
        internal static string UTA_TestContextLoadError {
            get {
                return ResourceManager.GetString("UTA_TestContextLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to set TestContext property for the class {0}. Error: {1}..
        /// </summary>
        internal static string UTA_TestContextSetError {
            get {
                return ResourceManager.GetString("UTA_TestContextSetError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0}.TestContext has incorrect type..
        /// </summary>
        internal static string UTA_TestContextTypeMismatchLoadError {
            get {
                return ResourceManager.GetString("UTA_TestContextTypeMismatchLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method {0}.{1} has wrong signature. The method must be non-static, public, does not return a value and should not take any parameter. Additionally, if you are using async-await in method then return-type must be Task..
        /// </summary>
        internal static string UTA_TestInitializeAndCleanupMethodHasWrongSignature {
            get {
                return ResourceManager.GetString("UTA_TestInitializeAndCleanupMethodHasWrongSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test method {0}.{1} threw exception: 
        ///{2}.
        /// </summary>
        internal static string UTA_TestMethodThrows {
            get {
                return ResourceManager.GetString("UTA_TestMethodThrows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get type {0}. Error: {1}..
        /// </summary>
        internal static string UTA_TypeLoadError {
            get {
                return ResourceManager.GetString("UTA_TypeLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}. If you are using UI objects in test consider using [UITestMethod] attribute instead of [TestMethod] to execute test in UI thread..
        /// </summary>
        internal static string UTA_WrongThread {
            get {
                return ResourceManager.GetString("UTA_WrongThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Failed to get the message for an exception of type {0} due to an exception.).
        /// </summary>
        internal static string UTF_FailedToGetExceptionMessage {
            get {
                return ResourceManager.GetString("UTF_FailedToGetExceptionMessage", resourceCulture);
            }
        }
    }
}
