using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/BuildingAdmin")]
    [ApiController]
    public class BuildingAdminController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public BuildingAdminController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var BuildingAdmins = _context.BuildingAdmins.ToList();
            return Ok(BuildingAdmins);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id)
        {
            var BuildingAdmin = _context.BuildingAdmins.Find(id);

            if (BuildingAdmin == null)
            {
                return NotFound();
            }
            return Ok(BuildingAdmin);
        }
    }
}