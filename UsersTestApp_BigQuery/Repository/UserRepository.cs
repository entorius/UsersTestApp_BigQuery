using Google.Cloud.BigQuery.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersTestApp_BigQuery.Entities;

namespace UsersTestApp_BigQuery.Repository
{
    public class UserRepository
    {
        string projectId = DatabaseSecrets.databaseProjectId;
        string datasetId = DatabaseSecrets.defaultDatasetName;
        string tableId = "User";                //Table ID in Google Big Query database
        public async Task<bool> addUsers(List<User> users)
        {
           
            var client = BigQueryClient.Create(projectId);
            int requestsNumber = users.Count / 10000;

            List<BigQueryInsertRow> rows = new List<BigQueryInsertRow>();
            for (int j = 0; j < requestsNumber; j++)
            {
                for (int i = j * 10000; i < (j+1) * 10000; i++)
                {
                    BigQueryInsertRow row = 
                        new BigQueryInsertRow(insertId: "row" + (i + 1)) 
                        {
                            { "UserId", users[i].UserId },
                            { "Country", users[i].Country},
                            { "FullName", users[i].FullName },
                            { "Email", users[i].Email },
                            { "CreatedAt", users[i].CreatedAt },
                            { "FirstNumber", users[i].FirstNumber },
                            { "SecondNumber", users[i].SecondNumber }
                        };

                    rows.Add(row);
                }
                await client.InsertRowsAsync(datasetId, tableId, rows);
                System.Threading.Thread.Sleep(1500);
            }
            if(users.Count % 10000 > 0)
            {
                
                for (int i = requestsNumber * 10000; i < users.Count; i++)
                {
                    BigQueryInsertRow row =
                        new BigQueryInsertRow(insertId: "row" + (i + 1))
                        {
                            { "UserId", users[i].UserId },
                            { "Country", users[i].Country},
                            { "FullName", users[i].FullName },
                            { "Email", users[i].Email },
                            { "CreatedAt", users[i].CreatedAt },
                            { "FirstNumber", users[i].FirstNumber },
                            { "SecondNumber", users[i].SecondNumber }
                        };

                    rows.Add(row);
                }
                await client.InsertRowsAsync(datasetId, tableId, rows);
            }
            return true;
        }
        public async Task<bool> selectUsers()
        {

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT * FROM {table} WHERE FirstNumber >= @number";
            BigQueryParameter[] parameters = new[]
            {
                new BigQueryParameter("number", BigQueryDbType.Int64, 200)
            };
            BigQueryResults results = await client.ExecuteQueryAsync(sql, parameters);
            /*foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }*/
            Console.WriteLine(results.ToList().Count);
            return true;
        }
        public async Task<bool> selectReplaceUsers()
        {

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT * REPLACE (FirstNumber / @divider AS FirstNumber) FROM {table}";
            BigQueryParameter[] parameters = new[]
            {
                new BigQueryParameter("divider", BigQueryDbType.Int64, 2)
            };
            BigQueryResults results = await client.ExecuteQueryAsync(sql, parameters);
            /*foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }*/
            Console.WriteLine(results.ToList().Count);
            return true;
        }
        public async Task<bool> selectExceptUsers()
        {

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT * EXCEPT (SecondNumber) FROM {table}";
           
            BigQueryResults results = await client.ExecuteQueryAsync(sql, parameters: null);
            /*foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }*/
            Console.WriteLine(results.ToList().Count);
            return true;
        }
        public async Task<bool> selectLimitUsers()
        {

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT * FROM {table} LIMIT 50000";

            BigQueryResults results = await client.ExecuteQueryAsync(sql, parameters: null);
            /*foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }*/
            Console.WriteLine(results.ToList().Count);
            
            return true;
        }
        public async Task<bool> selectSampleUsers()
        {

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT * FROM {table} ORDER BY rand() LIMIT 100";

            BigQueryResults results = await client.ExecuteQueryAsync(sql, parameters: null);
            /*foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }*/
            Console.WriteLine(results.ToList().Count);

            return true;
        }

        public async Task<bool> selectQualifyUsers()
        {

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT FullName, Country, CreatedAt, AvgFirstNumber, MinFirstNumber, TotalFirstNumber"+
                        "FROM("+
                        "SELECT FullName, Country, CreatedAt,"+
                        "AVG(FirstNumber) OVER(PARTITION BY Country) AS AvgFirstNumber,"+
                        "MIN(FirstNumber) OVER(PARTITION BY Country) AS MinFirstNumber,"+
                        "SUM(FirstNumber) OVER(PARTITION BY Country) AS TotalFirstNumber"+
                        $"FROM {table})" +
                        "WHERE AvgFirstNumber > 500;";

            BigQueryResults results = await client.ExecuteQueryAsync(sql, parameters: null);
            /*foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }*/
            Console.WriteLine(results.ToList().Count);

            return true;
        }
        public async Task<bool> selectNotEqualUsers()
        {

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT FullName, Country ,CreatedAt"+
                        $"FROM {table}"+
                        "WHERE Country != 'American Samoa'"+
                        "ORDER BY Country ASC; ";

            BigQueryResults results = await client.ExecuteQueryAsync(sql, parameters: null);
            /*foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }*/
            Console.WriteLine(results.ToList().Count);

            return true;
        }
    }
}
