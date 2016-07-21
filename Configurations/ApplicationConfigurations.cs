using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Whole of application level confications are here.
 */
namespace Configurations.LocalConfigurations
{
    public class ApplicationConfigurations
    {
        /**
         * Application's internal name
         */
        public string name { get; set; }

        /**
         * Application's version
         */
        public string version { get; set; }

        /**
         * Avaiable application modes
         * @see local
         * @see lan
         * @see dev
         * @see test
         * @see preview
         * @see live
         * @see demo
         */
        public string mode { get; set; }

        public DatabaseConfigurations database;
        public APIConfigurations api;

        public ApplicationConfigurations()
        {
            name = "Test Application";
            version = "0.0.1";

            mode = "dev";

            configureDatabase();
            configureAPI();
        }

        /**
         * @see https://www.connectionstrings.com/mysql/
         */
        public string getMySQLConnectionString()
        {
            string ConnectionString = string.Format("server={0};port={1};database={2};uid={3};pwd={4};", database.hostname, database.portnumber, database.database, database.username, database.password);
            return ConnectionString;
        }

        private void configureDatabase()
        {
            database = new DatabaseConfigurations();
            database.hostname = "localhost";
            database.portnumber = "3306";
            database.username = "root";
            database.password = "toor";
            database.database = "test";
        }

        private void configureAPI()
        {
            api = new APIConfigurations();

            api.url = "http://localhos/api";
            api.username = "username";
            api.password = "password";
        }
    }
}
