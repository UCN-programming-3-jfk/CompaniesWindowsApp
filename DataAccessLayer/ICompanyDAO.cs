using DataAccessLayer.Model;
using System.Collections.Generic;
namespace DataAccessLayer;
public interface ICompanyDAO
{
    public Company Get(int id);
    public IEnumerable<Company> GetAll();
    public Company GetCompanyByPartOfName(string partOfCompanyName);
    public int Add(Company Company);
    public bool Delete(int id);
    public bool Update(Company Company);
}