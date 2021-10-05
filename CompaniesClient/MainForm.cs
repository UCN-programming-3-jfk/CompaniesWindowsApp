using CompaniesClient.DTO;
using CompaniesClient.ServiceLayer;
using DataAccessLayer;
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
        public ICompanyService DataAccess { get; set; }

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


        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUi();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedCompany();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSelectedCompany();
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
                EditSelectedCompany();
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
        private void UpdateUi()
        {
            lstCompanies.Refresh();
            if (lstCompanies.SelectedItem != null)
            {
                UpdateSelectedCompanyOnUI();
            }
            btnDelete.Enabled = btnEdit.Enabled = lstCompanies.SelectedIndex != -1;
        }

        private void DeleteSelectedCompany()
        {
            if (lstCompanies.SelectedIndex == -1) { return; }
            Company companyToDelete = (Company)lstCompanies.SelectedItem;
            if (MessageBox.Show("Are you sure you wish to delete this company?", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DataAccess.DeleteCompany(companyToDelete.Id);
                lstCompanies.Items.Remove(companyToDelete); 
            }
        }

        private void UpdateSelectedCompanyOnUI()
        {
            if (lstCompanies.SelectedIndex == -1) { return; }
            Company company = (Company)lstCompanies.SelectedItem;
            lblCompanyName.Text = company.Name;
            lblNumberOfEmployees.Text = "Number of employees: " + company.NumberOfEmployees;
            lblYearlyEarningsInUsDollars.Text = "Yearly earnings in USD: " + company.YearlyEarningsInUSDollars;
            lblCountry.Text = "Country: " + company.Country;
            chkPublicCompany.Checked = company.IsPublic;
        }

        private void EditSelectedCompany()
        {
            if(lstCompanies.SelectedIndex == -1) { return; }
            Company selectedCompany = (Company)lstCompanies.SelectedItem;
            var editorForm = new CompanyForm(selectedCompany);
            if (editorForm.ShowDialog() == DialogResult.OK)
            {
                DataAccess.UpdateCompany(editorForm.Company);
                UpdateUi();
            }
        }
    }
}