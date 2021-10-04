using CompaniesClient.ServiceLayer;
using DataAccessLayer;
using DataAccessLayer.Model;
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
        public ICompanyDataAccess DataAccess { get; set; }

        public MainForm()
        {
            InitializeComponent();
            DataAccess = new RestApiDataAccess("https://localhost:44317/api/v1/companies");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateUi();
        }

        private void LoadData()
        {
            lstCompanies.Items.Clear();
            foreach (var company in DataAccess.GetAll())
            {
                lstCompanies.Items.Add(company);
            }
            if (lstCompanies.Items.Count > 0) { lstCompanies.SelectedIndex = 0; }
        }

        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUi();
            UpdateSelectedCompany((Company)lstCompanies.SelectedItem);
        }

        private void UpdateUi()
        {
            lstCompanies.Refresh();
            if (lstCompanies.SelectedItem != null)
            {
                UpdateSelectedCompany((Company)lstCompanies.SelectedItem);
            }
            btnDelete.Enabled = btnEdit.Enabled = lstCompanies.SelectedIndex != -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCompany((Company)lstCompanies.SelectedItem);
        }

        private void DeleteCompany(Company companyToDelete)
        {
            DataAccess.DeleteCompany(companyToDelete.Id);
            lstCompanies.Items.Remove(companyToDelete);
            //LoadData();
            //UpdateUi();
        }

        private void UpdateSelectedCompany(Company company)
        {
            if (company == null) { return; }
            lblCompanyName.Text = company.Name;
            lblNumberOfEmployees.Text = "Number of employees: " + company.NumberOfEmployees;
            lblYearlyEarningsInUsDollars.Text = "Yearly earnings in USD: " + company.YearlyEarningsInUSDollars;
            lblCountry.Text = "Country: " + company.Country;
            chkPublicCompany.Checked = company.IsPublic;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSelectedCompany((Company)lstCompanies.SelectedItem);
            
        }

        private void EditSelectedCompany(Company selectedItem)
        {
            var editorForm = new CompanyForm(selectedItem);
            if (editorForm.ShowDialog() == DialogResult.OK)
            {
                DataAccess.UpdateCompany(editorForm.Company);
                UpdateUi();
            }
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            var editorForm = new CompanyForm();
            if (editorForm.ShowDialog() == DialogResult.OK)
            {
                var newCompany = editorForm.Company;
                int newId = DataAccess.AddCompany(newCompany);
                newCompany.Id = newId;
                lstCompanies.Items.Add(newCompany);
                UpdateUi();
            }
        }

        private void lstCompanies_DoubleClick(object sender, EventArgs e)
        {
            if (lstCompanies.SelectedIndex !=-1)
            {
                EditSelectedCompany((Company)lstCompanies.SelectedItem);
            }
        }
    }
}