using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Walker.API.Interfaces;
using Walker.API.Model;

namespace Walker.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LeadController : ControllerBase
    {
        private readonly ILeadService _leadService;
        public LeadController(ILeadService leadService)
        {
            _leadService = leadService;
        }
        [HttpGet]
        public IEnumerable<Lead> Get()
        {
            return _leadService.GetLeads();
        }

        [HttpPost]
        public IActionResult PostLead([FromBody] Lead lead)
        {
            try
            {
                _leadService.SaveLead(lead);
                return Ok(_leadService.GetLeads());
            }
            catch (Exception e)
            {
                return BadRequest("Format is incorrect");
            }
        }
    }
}