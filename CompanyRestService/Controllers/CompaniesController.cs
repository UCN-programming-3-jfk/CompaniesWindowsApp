using DataAccessLayer;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompanyRestService.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CompaniesController : ControllerBase
{

    private ICompanyDAO dataAccess;

    public CompaniesController(ICompanyDAO dataAccess)
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
        return Ok(dataAccess.Add(company));
    }

    [HttpPut]
    public ActionResult<bool> Update(Company company)
    {
        return Ok(dataAccess.Update(company));
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult<Company> Get(int id)
    {
        var company= dataAccess.Get(id);
        if (company == null) { return NotFound(); }
        return Ok(company);
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult<bool> Delete(int id)
    {
        if (dataAccess.Delete(id))
        {
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}