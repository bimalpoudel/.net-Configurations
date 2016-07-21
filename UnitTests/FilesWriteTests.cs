using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

// @see https://msdn.microsoft.com/en-us/library/system.io.file.delete(v=vs.110).aspx

namespace Configurations.UnitTests
{
    /**
     * To verify that the system can write to arbitrary files
     */
    /// <summary>
    /// Summary description for FileWriteTests
    /// </summary>
    [TestClass]
    public class FilesWriteTests
    {
        string filePath = @"c:\logger-filewriter-tests.log";

        private TestContext testContextInstance;

        public FilesWriteTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        
        [TestMethod]
        [TestCategory("File Writer")]
        public void FileDoesNotExist()
        {
            Assert.IsFalse(File.Exists(filePath));
        }


        [TestMethod]
        [TestCategory("File Writer")]
        public void FileCanWrite()
        {
            File.WriteAllText(filePath, "I am a test log.");
            Assert.IsTrue(File.Exists(filePath));
        }

        [TestMethod]
        [TestCategory("File Writer")]
        public void FileExists()
        {
            Assert.IsTrue(File.Exists(filePath));
        }

        [TestMethod]
        [TestCategory("File Writer")]
        public void FileCanDelete()
        {
            Assert.IsTrue(File.Exists(filePath));
            File.Delete(filePath);
            Assert.IsFalse(File.Exists(filePath));
        }
    }
}
