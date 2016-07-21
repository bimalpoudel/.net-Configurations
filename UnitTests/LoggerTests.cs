using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Configurations.LogWriters;

namespace Configurations.UnitTests
{
    /**
     * To verify that the system can write to defined file names
     * @see https://blogs.msdn.microsoft.com/csharpfaq/2006/03/27/how-can-i-easily-log-a-message-to-a-file-for-debugging-purposes/
     */
    [TestClass]
    public class LoggerTests
    {
        string filePath = @"c:\logger-writer-tests.log";
        string filePath2 = @"c:\logger-writer-tests-secondary.log";

        private void CleanUp()
        {
            /**
             * @todo Files can be locked in
             */
            if (File.Exists(this.filePath))
            {
                File.Delete(this.filePath);
            }

            if (File.Exists(this.filePath2))
            {
                File.Delete(this.filePath2);
            }
        }

        [TestMethod]
        [TestCategory("Log Writer")]
        public void WriteLogsNormally()
        {
            this.CleanUp();

            Logger logger1 = new Logger();
            logger1.logTo(this.filePath);
            logger1.write("Hi, I am a log line");
            logger1.write("Hi, I am another log line");
            Assert.IsTrue(File.Exists(this.filePath));

            Logger logger2 = new Logger();
            logger2.logTo(this.filePath2);
            logger2.write("Hi, I am a log line");
            logger2.write("Hi, I am another log line");
            Assert.IsTrue(File.Exists(this.filePath2));
        }

        [TestMethod]
        [TestCategory("Log Writer")]
        public void AppendLogs()
        {
            this.CleanUp();

            Logger logger1 = new Logger();
            logger1.logTo(this.filePath);
            logger1.write("Hi, I am a log line");
            FileInfo fi1 = new FileInfo(this.filePath);
            double length1 = fi1.Length;

            logger1 = null;

            Logger logger2 = new Logger();
            logger2.logTo(this.filePath2);
            logger2.write("Hi, I am another log line with different content.");
            FileInfo fi2 = new FileInfo(this.filePath2);
            double length2 = fi2.Length;

            logger2 = null;

            // file size is different after writing a log content
            // @see https://msdn.microsoft.com/en-us/library/system.io.fileinfo.length(v=vs.110).aspx
            Assert.AreNotEqual(length1, length2);
        }

        [TestMethod]
        [TestCategory("Log Writer")]
        public void WriteToInvalidFile()
        {
            this.CleanUp();
            try
            {
                Logger logger1 = new Logger();
                // logger1.logTo(filePath); // yes, forget it; do NOT define
                logger1.write("I must throw an exception!");
                Assert.IsFalse(File.Exists(this.filePath));
            }
            catch(Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
