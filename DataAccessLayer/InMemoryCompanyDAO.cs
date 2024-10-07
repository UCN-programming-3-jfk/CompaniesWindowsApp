using DataAccessLayer.Model;
using System;
using System.Collections.Generic;

namespace DataAccessLayer;
public class InMemoryCompanyDAO : ICompanyDAO
{
    private static int nextId = 0;

    private List<Company> companies = new List<Company>();

    public InMemoryCompanyDAO()
    {
        AddCompanies();
    }

    private void AddCompanies()
    {
        Add(new Company() { Name = "Johnson's Hammers", Country = "USA", IsPublic = false, NumberOfEmployees = 52, YearlyEarningsInUSDollars = 2500000 });
        Add(new Company() { Name = "InTech", Country = "England", IsPublic = true, NumberOfEmployees = 152, YearlyEarningsInUSDollars = 12500000 });
        Add(new Company() { Name = "Zubrecht Pharmaceuticals", Country = "Belgium", IsPublic = true, NumberOfEmployees = 789, YearlyEarningsInUSDollars = 78000000 });
        Add(new Company() { Name = "Aahad's Bakery", Country = "Lebanon", IsPublic = false, NumberOfEmployees = 6, YearlyEarningsInUSDollars = 15000 });
        Add(new Company() { Name = "Odense Guldbageren", Country = "Denmark", IsPublic = false, NumberOfEmployees = 12, YearlyEarningsInUSDollars = 1500000 });
    }

    public int Add(Company company)
    {
        company.Id = GetNextId();
        companies.Add(company);
        return company.Id;
    }

    public bool Delete(int id)
    {
        return companies.Remove(companies.Find(company => company.Id == id));
    }

    public IEnumerable<Company> GetAll()
    {
        return new List<Company>(companies);
    }

    public Company Get(int id)
    {
        return companies.Find(company => company.Id == id);
    }

    public Company GetCompanyByPartOfName(string partOfCompanyName)
    {
        return companies.Find(company => company.Name.Contains(partOfCompanyName, StringComparison.InvariantCultureIgnoreCase));
    }

    public bool Update(Company updatedCompany)
    {
        Company existingCompany = Get(updatedCompany.Id);
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