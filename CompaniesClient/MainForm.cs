using CompaniesClient.DAL.DTO;
using CompaniesClient.ServiceLayer;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace CompaniesClient;

public partial class MainForm : Form
{
    #region Variables and constructor
    private ICompanyDAO _companyDAO;

    public MainForm()
    {
        InitializeComponent();
        _companyDAO = new RestApiCompanyDAO("https://localhost:44317/api/v1/companies");
    } 
    #endregion

    #region Eventhandlers
    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadData();
        UpdateUi();
    }
    private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e) { UpdateUi(); }
    private void lstCompanies_DoubleClick(object sender, EventArgs e) { EditSelectedCompany(); }
    private void btnDelete_Click(object sender, EventArgs e) { DeleteSelectedCompany(); }
    private void btnEdit_Click(object sender, EventArgs e) { EditSelectedCompany(); }
    private void btnNewCompany_Click(object sender, EventArgs e) { NewCompany(); }  
    #endregion

    #region Functionality
    private void LoadData()
    {
        try
        {
            lstCompanies.Items.Clear();
            foreach (var company in _companyDAO.GetAll())
            {
                lstCompanies.Items.Add(company);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving data from the server. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        if (lstCompanies.Items.Count > 0) { lstCompanies.SelectedIndex = 0; }
    }
    private void UpdateUi()
    {
        if (lstCompanies.SelectedIndex != -1)
        {
            UpdateSelectedCompanyOnUI();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }
        else
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
        
    }
    private void EditSelectedCompany()
    {
        if (lstCompanies.SelectedIndex == -1) { return; }
        Company selectedCompany = (Company)lstCompanies.SelectedItem;
        var editorForm = new CompanyForm(selectedCompany);
        if (editorForm.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _companyDAO.Update(editorForm.Company);
                //Hack
                //  - to enable the text to update on the listitem
                //    we set it to itself
                lstCompanies.Items[lstCompanies.SelectedIndex] = lstCompanies.Items[lstCompanies.SelectedIndex];
                UpdateUi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data on the server. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void DeleteSelectedCompany()
    {
        if (lstCompanies.SelectedIndex == -1) { return; }
        if (MessageBox.Show("Are you sure you wish to delete this company?", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        {
            try
            {
                Company companyToDelete = (Company)lstCompanies.SelectedItem;
                _companyDAO.Delete(companyToDelete.Id);
                lstCompanies.Items.Remove(companyToDelete);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting data on the server. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
    private void NewCompany()
    {
        var editorForm = new CompanyForm();
        if (editorForm.ShowDialog() == DialogResult.OK)
        {
            var newCompany = editorForm.Company;
            try
            {
                int newId = _companyDAO.Add(newCompany);
                newCompany.Id = newId;
                lstCompanies.Items.Add(newCompany);
                UpdateUi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving new company on the server. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    #endregion
}