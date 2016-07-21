using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @see http://jai-on-asp.blogspot.ca/2010/03/finding-hardware-id-of-computer.html
 */
/**
namespace Configurations.HardwareIdentities
{
   class HardDiskIDs
   {
       public void IDs()
       {

           ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");

           dsk.Get();
           string id = dsk["VolumeSerialNumber"].ToString();
       }
   }
}
*/
