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
        public IEnumerable<Company> Get()
        {
            return DataAccess.GetAll();
        }
    }
}