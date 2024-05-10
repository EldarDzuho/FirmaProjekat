using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/BuildingTenant")]
    [ApiController]
    public class BuildingTenantController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public BuildingTenantController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var BuildingTenants = _context.BuildingTenants.ToList();
            return Ok(BuildingTenants);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id)
        {
            var BuildingTenant = _context.BuildingTenants.Find(id);

            if (BuildingTenant == null)
            {
                return NotFound();
            }
            return Ok(BuildingTenant);
        }
    }
}