using CompaniesClient.DAL.DTO;
using System.Collections.Generic;

namespace DataAccessLayer;

public interface ICompanyDAO
{
    public IEnumerable<Company> GetAll();
    public Company Get(int id);
    public int Add(Company Company);
    public bool Delete(int id);
    public bool Update(Company Company);

    public Company GetCompanyByPartOfName(string partOfCompanyName);
}