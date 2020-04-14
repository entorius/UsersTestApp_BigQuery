using Google.Cloud.BigQuery.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersTestApp_BigQuery.Services
{
    public class BigQueryCreateDataset
    {
        public BigQueryDataset CreateDataset( string projectId ,
            string location, string datasetId
            )
        {
            BigQueryClient client = BigQueryClient.Create(projectId);
            var createDatasetOptions = new CreateDatasetOptions()
            {
                // Specify the geographic location where the dataset should reside.
                Location = location
            };
            // Create the dataset
            return client.CreateDataset(
                datasetId: datasetId, options: createDatasetOptions);
        }
    }
}
