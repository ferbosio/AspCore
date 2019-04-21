using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPruebaAspCore.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppPruebaAspCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            this._context = context;
            this._unitOfWork = new UnitOfWork(this._context);
        }
        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            var values = _unitOfWork.ValuesRepository.Get(x => x.Id > 2, q => q.OrderBy(s => s.Id)).ToList();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = _unitOfWork.ValuesRepository.GetByID(id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
