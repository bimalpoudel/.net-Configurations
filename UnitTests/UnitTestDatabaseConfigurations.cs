using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Configurations.LocalConfigurations;
using Configurations.HardwareIdentities;

namespace Configurations.UnitTests
{
    [TestClass]
    public class UnitTestDatabaseConfigurations
    {
        [TestMethod]
        public void TestMethod1()
        {
            NICAddresses na = new NICAddresses();
        }

        [TestMethod]
        public void TestDatabaseConfigurations()
        {
            ApplicationConfigurations ac = new ApplicationConfigurations();

            Assert.AreNotEqual("", ac.database.hostname);
            Assert.AreNotEqual("", ac.database.portnumber);
            Assert.AreNotEqual("", ac.database.username);
            Assert.AreNotEqual("", ac.database.password);
            Assert.AreNotEqual("", ac.database.database);
        }

        [TestMethod]
        public void TestDatabaseConfigurationsValues()
        {
            ApplicationConfigurations ac = new ApplicationConfigurations();

            Assert.AreEqual("localhost", ac.database.hostname, false, "Hostname defined");
            Assert.AreEqual("3036", ac.database.portnumber, false, "Port number defined");
            Assert.AreEqual("root", ac.database.username, false, "Username defined");
            Assert.AreEqual("toor", ac.database.password, false, "Password defined");
            Assert.AreEqual("test", ac.database.database, false, "Database defined");
        }
    }
}
