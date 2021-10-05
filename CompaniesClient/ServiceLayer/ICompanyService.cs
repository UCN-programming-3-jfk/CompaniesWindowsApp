using CompaniesClient.DTO;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAll();
        public Company GetCompanyById(int id);
        public Company GetCompanyByPartOfName(string partOfCompanyName);
        public int AddCompany(Company Company);
        public bool DeleteCompany(int id);
        public bool UpdateCompany(Company Company);
    }
}
