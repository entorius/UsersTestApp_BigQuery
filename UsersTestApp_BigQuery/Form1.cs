using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersTestApp_BigQuery.Entities;
using UsersTestApp_BigQuery.Repository;
using UsersTestApp_BigQuery.Services;

namespace UsersTestApp_BigQuery
{
    public partial class Form1 : Form
    {
        UserServices userServices = new UserServices();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button_ImportDataToDatabase_Click(object sender, EventArgs e)
        {
            JsonToObject reader = new JsonToObject();
            string path = "Data.json";
            List<User> users = reader.JsonToUsersList(path);

            if (users.Count > 0) 
            {
                await userServices.addUsers(users);
            }
            else
            {
                Console.WriteLine("No rows loaded from json file");
            }
        }

        private void Button_CreateDataset_Click(object sender, EventArgs e)
        {
            if (TextBox_DatasetName.Text.Length > 0) 
            {
                string datasetName = TextBox_DatasetName.Text;

                BigQueryCreateDataset c = new BigQueryCreateDataset();

                c.CreateDataset(DatabaseSecrets.databaseProjectId,
                    DatabaseSecrets.databaseLocation, datasetName);
            }
        }

        private async void Button_Select_Click(object sender, EventArgs e)
        {
            await userServices.selectUsers();
        }

        private async void Button_SelectReplace_Click(object sender, EventArgs e)
        {
            await userServices.selectReplaceUsers();
        }

        private async void Button_SelectExcept_Click(object sender, EventArgs e)
        {
            await userServices.selectExceptUsers();
        }

        private async void Button_SelectLimit_Click(object sender, EventArgs e)
        {
            await userServices.selectLimitUsers();
        }

        private async void Button_SelectSample_Click(object sender, EventArgs e)
        {
            await userServices.selectSampleUsers();
        }

        private async void Button_SelectQualify_Click(object sender, EventArgs e)
        {
            await userServices.selectSampleUsers();
        }

        private async void Button_SelectNotEqual_Click(object sender, EventArgs e)
        {
            await userServices.selectNotEqualUsers();
        }
    }
}
