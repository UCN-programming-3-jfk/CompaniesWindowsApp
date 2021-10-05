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

        private ICompanyDataAccess dataAccess;

        public CompaniesController(ICompanyDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return Ok(dataAccess.GetAll());
        }

        [HttpPost]
        public ActionResult<int> Add(Company company)
        {
            return Ok(dataAccess.AddCompany(company));
        }

        [HttpPut]
        public ActionResult<bool> Update(Company company)
        {
            return Ok(dataAccess.UpdateCompany(company));
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Company> Get(int id)
        {
            var company= dataAccess.GetCompanyById(id);
            if (company == null) { return NotFound(); }
            return Ok(company);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (dataAccess.DeleteCompany(id))
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