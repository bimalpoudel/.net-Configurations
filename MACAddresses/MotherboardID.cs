using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @see http://jai-on-asp.blogspot.ca/2010/03/finding-hardware-id-of-computer.html
 *//**
namespace Configurations.HardwareIdentities
{
    public class MotherboardID
    {
        public void IDs()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string serial = "";
            foreach (ManagementObject mo in moc)
            {
                serial = (string)mo["SerialNumber"];
            }
        }
    }
}
*/