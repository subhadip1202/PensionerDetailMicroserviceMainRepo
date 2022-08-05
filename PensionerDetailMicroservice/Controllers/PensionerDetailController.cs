using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PensionerDetailMicroservice.Data;
using PensionerDetailMicroservice.Models;
using PensionerDetailMicroservice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailMicroservice.Controllers
{
    [Route("api/pensionerdetail")]
    [ApiController]
    public class PensionerDetailController : ControllerBase
    {
        private readonly IRepo _irepo;
        public PensionerDetailController(IRepo irepo )
        {
            _irepo = irepo;
        }

        [HttpGet("{id:int}")]

        public IActionResult GetPensionerDetail(int id)
        {
            try
            {
                if (Convert.ToString(id)== "null")
                {
                    return NotFound();
                }
                dynamic employee = _irepo.getAllDetails(id);
                if(employee == null)
                {
                    return BadRequest("Invalid User");
                }
                return Ok(employee);
            }
            catch (Exception)
            {
                throw;
            }
            //   var employees = await _pensionDbContext.pensionerDetailModels.FromSqlRaw("SELECT * From dbo.pensionerdetailmodels").Where(p => p.aadharno == id).ToListAsync();

         
        }


    }
}
