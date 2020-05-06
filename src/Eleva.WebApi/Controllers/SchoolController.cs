using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eleva.Application.DTO;
using Eleva.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eleva.WebApi.Controllers
{
    [Route("api/escolas")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet]
        public async Task<IEnumerable<SchoolDTO>> GetAll()
        {
            return await _schoolService.GetAll();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<SchoolDTO>> GetById(Guid id)
        {
            var school = await _schoolService.GetById(id);

            if (school == null) return NotFound();

            return Ok(school);
        }

        [HttpPost]
        public async Task<ActionResult<SchoolDTO>> Create(SchoolDTO schoolDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = await _schoolService.Create(schoolDTO);

            if (!result) return BadRequest();

            return Ok(schoolDTO);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<SchoolDTO>> Update(Guid id, SchoolDTO schoolDTO)
        {
            if (schoolDTO.Id != id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var result = await _schoolService.Update(schoolDTO);

            if (!result) return BadRequest();

            return Ok(schoolDTO);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<SchoolDTO>> Destroy(Guid id)
        {
            var school = await this.GetById(id);

            if (school == null) return NotFound();

            var result = await _schoolService.Destroy(id);

            if (!result) return BadRequest();

            return Ok(school);
        }
    }
}