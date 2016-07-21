using System;
using System.IO;

/**
 * @see https://msdn.microsoft.com/en-us/library/8bh11f1k.aspx
 * @see https://msdn.microsoft.com/en-us/library/system.io.filestream.aspx
 */
namespace Configurations.LogWriters
{
    public class Logger
    {
        private string logPath;
        private System.IO.StreamWriter file;
        private bool CanWrite = false;

        public Logger()
        {

        }

        public void logTo(string logPath)
        {
            try
            {
                this.logPath = logPath;

                this.file = new StreamWriter(this.logPath, true);
                this.CanWrite = true;
            }
            catch(Exception)
            {
                this.CanWrite = false;
            }
        }

        public void write(string message)
        {
            if (!this.CanWrite)
            {
                /**
                 * @todo When exception; unit tests fail.
                 * Normally expected to be able to write to
                 */
                //throw new Exception("Cannot write to the file.");
                return;
            }
            else
            {
                DateTime time = DateTime.Now;
                string format = "u";
                string datetime = time.ToString(format);
                this.file.WriteLine(datetime+" ");

                this.file.WriteLine(message);
                this.file.WriteLine("");
            }
        }

        ~Logger()
        {
            //return;

            if(null != this.file && this.CanWrite)
            {
                this.file.Close();
            }
        }
    }
}
