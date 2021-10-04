using DataAccessLayer.Model;
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
    public partial class CompanyForm : Form
    {
        private Company company;

        public Company Company { get => company; set { 
                company = value;
                CopyValuesFromCompanyObjectToControls();
            } }

        private void CopyValuesFromCompanyObjectToControls()
        {
            if (Company == null) { return; }
            txtCompanyName.Text = Company.Name;
            txtNumberOfEmployees.Text = Company.NumberOfEmployees.ToString();
            txtYearlyEarningsInUsd.Text = Company.YearlyEarningsInUSDollars.ToString();
            txtCountry.Text = Company.Country;
            chkPublicCompany.Checked = Company.IsPublic;
        }

        public CompanyForm(Company companyToEdit = null)
        {
            InitializeComponent();
            Company = companyToEdit;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Company == null) { company = new Company(); }

            CopyValuesFromControlsToCompanyObject();
        }

        private void CopyValuesFromControlsToCompanyObject()
        {
            Company.Name = txtCompanyName.Text;
            Company.NumberOfEmployees = int.Parse(txtNumberOfEmployees.Text);
            Company.YearlyEarningsInUSDollars = int.Parse(txtYearlyEarningsInUsd.Text);
            Company.Country = txtCountry.Text;
            Company.IsPublic = chkPublicCompany.Checked;
        }
    }
}
