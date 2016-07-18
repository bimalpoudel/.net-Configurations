using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurations.HardwareIdentities
{
    public class Processors
    {
        public string GetProcessorID()
        {
            /*
            string sProcessorID = "";

            string sQuery = "SELECT ProcessorId FROM Win32_Processor";

            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher(sQuery);

            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();

            foreach (ManagementObject oManagementObject in oCollection)

            {

                sProcessorID = (string)oManagementObject["ProcessorId"];

            }

            return (sProcessorID);
            */

            return "";

        }
    }
}
