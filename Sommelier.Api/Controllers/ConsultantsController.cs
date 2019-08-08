using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sommelier.Models.Persons;
using Sommelier.Services.Persons;

namespace Sommelier.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        private readonly IConsultantsService consultantsService;

        public ConsultantsController(IConsultantsService consultantsService)
        {
            this.consultantsService = consultantsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var consultants = this.consultantsService.GetAllConsultants();
            return Ok(consultants);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(Guid id)
        {
            var consultant = this.consultantsService.GetConsultantById(id);

            if(consultant == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(consultant);
            }
        }

        [HttpPost]
        public IActionResult Post(Consultant consultant)
        {
            var newConsultant = this.consultantsService.CreateConsultant(consultant);

            return CreatedAtAction("Get", newConsultant);
        }

        [HttpDelete]
        public IActionResult Delete(Consultant consultant)
        {
            this.consultantsService.DeleteConsultant(consultant);
            return NoContent();
        }
    }
}