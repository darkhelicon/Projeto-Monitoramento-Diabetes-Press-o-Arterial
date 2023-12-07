using APIHM.Services;
using APIHM.Services.Interfaces;
using APIHM.Validator;
using AutoMapper;
using Common;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HiperController : ControllerBase
    {
        private readonly IHiperService _hiperService;
        public readonly IMapper _mapper;
        public HiperController(IHiperService hiperService, IMapper mapper)
        {
            _hiperService = hiperService;
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/<TesteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost("Create")]
        public IActionResult Add(DataModel data)
        {
            return Ok();
        }
        [HttpPost("GetPeriod")]
        public IActionResult GetPeriod(DataModel data)
        {
            var result = _hiperService.HiperPeriod(data);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // PUT api/<TesteController>/5
        [HttpPut("{id}")]
        public void Patch(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TesteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
