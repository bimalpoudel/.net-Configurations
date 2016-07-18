using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurations.LocalConfigurations
{
    public class ApplicationConfigurations
    {
        public DatabaseConfigurations database;
        public APIConfigurations api;

        public ApplicationConfigurations()
        {
            // modes: local, lan, dev, test, preview, live, demo
            configureDatabase();
            configureAPI();
        }

        public void configureDatabase()
        {
            database = new DatabaseConfigurations();
            database.hostname = "localhost";
            database.portnumber = "3036";
            database.username = "root";
            database.password = "toor";
            database.database = "test";
        }

        public void configureAPI()
        {
            api = new APIConfigurations();

            api.url = "http://localhos/api";
            api.username = "username";
            api.password = "password";
        }
    }
}
