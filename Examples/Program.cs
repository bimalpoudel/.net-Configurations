using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configurations.HardwareIdentities;
using Configurations.LocalConfigurations;

namespace Configurations.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            test.showNetworkAddresses();
            test.showApplicationConfigurations();

            Console.ReadLine();
        }

        public void showNetworkAddresses()
        {
            NICAddresses na = new NICAddresses();
            na.ShowNetworkInterfaces();
        }

        public void showApplicationConfigurations()
        {
            ApplicationConfigurations ac = new ApplicationConfigurations();
            Console.WriteLine("Host: {0}, Port: {1}, Username: {2}, Password: {3}, Database: {4}", ac.database.hostname, ac.database.portnumber, ac.database.username, ac.database.password, ac.database.database);
        }
    }
}
