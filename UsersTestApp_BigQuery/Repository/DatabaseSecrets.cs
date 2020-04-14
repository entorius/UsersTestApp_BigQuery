using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersTestApp_BigQuery.Repository
{
    public static class DatabaseSecrets
    {
        public static string databaseProjectId = "test-users-progect";          //Project id of database in Google Cloud BigQuery
        public static string databaseLocation = "europe-north1";                //Location of database in Google Cloud BigQuery
        public static string defaultDatasetName = "UsersTestDataset";            //Dataset name in database in Google Cloud BigQuery
    }
}
