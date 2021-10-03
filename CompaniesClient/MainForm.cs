using CompaniesClient.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompaniesClient
{
    public partial class MainForm : Form
    {

        RestClient client;
        public MainForm()
        {
            InitializeComponent();
            client = new RestClient("https://localhost:44317/api/v1/companies");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var companies = client.Execute<IEnumerable<Company>>(new RestRequest());
            lstCompanies.DisplayMember = "Name";
            lstCompanies.DataSource = companies.Data;
        }
    }
}
