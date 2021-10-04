using DataAccessLayer;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompanyRestService.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CompaniesController : ControllerBase
    {

        public ICompanyDataAccess DataAccess { get; set; }

        public CompaniesController(ICompanyDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return Ok(DataAccess.GetAll());
        }

        [HttpPost]
        public ActionResult<int> Add(Company company)
        {
            return Ok(DataAccess.AddCompany(company));
        }

        [HttpPut]
        public ActionResult<bool> Update(Company company)
        {
            return Ok(DataAccess.UpdateCompany(company));
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Company> Get(int id)
        {
            var company= DataAccess.GetCompanyById(id);
            if (company == null) { return NotFound(); }
            return Ok(company);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (DataAccess.DeleteCompany(id))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
            
        }


    }
}