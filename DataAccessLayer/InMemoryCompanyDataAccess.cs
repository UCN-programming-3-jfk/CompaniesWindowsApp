using DataAccessLayer.Model;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class InMemoryCompanyDataAccess : ICompanyDataAccess
    {
        private static int nextId = 1;

        private List<Company> companies = new List<Company>();

        public InMemoryCompanyDataAccess()
        {
            AddCompanies();
        }

        private void AddCompanies()
        {
            AddCompany(new Company() { Name = "Johnson's Hammers", Country = "USA", IsPublic = false, NumberOfEmployees = 52, YearlyEarningsInUSDollars = 2500000 });
            AddCompany(new Company() { Name = "InTech", Country = "England", IsPublic = true, NumberOfEmployees = 152, YearlyEarningsInUSDollars = 12500000 });
            AddCompany(new Company() { Name = "Zubrecht Pharmaceuticals", Country = "Belgium", IsPublic = true, NumberOfEmployees = 789, YearlyEarningsInUSDollars = 78000000 });
            AddCompany(new Company() { Name = "Aahad's Bakery", Country = "Lebanon", IsPublic = false, NumberOfEmployees = 6, YearlyEarningsInUSDollars = 15000 });
            AddCompany(new Company() { Name = "Odense Guldbageren", Country = "Denmark", IsPublic = false, NumberOfEmployees = 12, YearlyEarningsInUSDollars = 1500000 });
        }

        public int AddCompany(Company company)
        {
            company.Id = GetNextId();
            companies.Add(company);
            return company.Id;
        }

        public bool DeleteCompany(int id)
        {
            return companies.Remove(companies.Find(company => company.Id == id));
        }

        public IEnumerable<Company> GetAll()
        {
            return new List<Company>(companies);
        }

        public Company GetCompanyById(int id)
        {
            return companies.Find(company => company.Id == id);
        }

        public Company GetCompanyByPartOfName(string partOfCompanyName)
        {
            return companies.Find(company => company.Name.Contains(partOfCompanyName, StringComparison.InvariantCultureIgnoreCase));
        }

        public bool UpdateCompany(Company updatedCompany)
        {
            Company existingCompany = GetCompanyById(updatedCompany.Id);
            if (existingCompany == null) { return false; }
            CopyValues(existingCompany, updatedCompany);
            return true;
        }

        private static void CopyValues(Company existingCompany, Company updatedCompany)
        {
            existingCompany.Name = updatedCompany.Name;
            existingCompany.NumberOfEmployees = updatedCompany.NumberOfEmployees;
            existingCompany.YearlyEarningsInUSDollars = updatedCompany.YearlyEarningsInUSDollars;
            existingCompany.Country = updatedCompany.Country;
            existingCompany.IsPublic = updatedCompany.IsPublic;
        }

        private static int GetNextId()
        {
            nextId++;
            return nextId;
        }
    }
}
