using CompaniesClient.DTO;
using System;
using System.Windows.Forms;

namespace CompaniesClient
{
    public partial class CompanyForm : Form
    {
        #region Properties
        private Company company;

        public Company Company
        {
            get => company; set
            {
                company = value;
                CopyValuesFromCompanyObjectToControls();
            }
        } 
        #endregion


        public CompanyForm(Company companyToEdit = null)
        {
            InitializeComponent();
            //use the Company object if one was provided
            //if it is NULL, create a new, blank, one
            if (companyToEdit == null) { companyToEdit = new Company(); }
            Company = companyToEdit;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CopyValuesFromControlsToCompanyObject();
        }

        private void CopyValuesFromCompanyObjectToControls()
        {
            if (Company == null) { return; }
            txtCompanyName.Text = Company.Name;
            txtNumberOfEmployees.Text = Company.NumberOfEmployees.ToString();
            txtYearlyEarningsInUsd.Text = Company.YearlyEarningsInUSDollars.ToString();
            txtCountry.Text = Company.Country;
            chkPublicCompany.Checked = Company.IsPublic;
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