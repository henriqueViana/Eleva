using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eleva.Application.DTO;
using Eleva.Domain.Interfaces;
using Eleva.Domain.Models;
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
        public async Task<ActionResult<IEnumerable<School>>> GetAll()
        {
            return Ok(await _schoolService.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<School>> GetById(Guid id)
        {
            var school = await _schoolService.GetById(id);

            if (school == null) return NotFound();

            return Ok(school);
        }

        [HttpPost]
        public async Task<ActionResult<School>> Create(School school)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = await _schoolService.Create(school);

            if (!result) return BadRequest();

            return Ok(school);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<School>> Update(Guid id, School school)
        {
            if (school.Id != id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var result = await _schoolService.Update(school);

            if (!result) return BadRequest();

            return Ok(school);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<School>> Destroy(Guid id)
        {
            var school = await this.GetById(id);

            if (school == null) return NotFound();

            var result = await _schoolService.Destroy(id);

            if (!result) return BadRequest();

            return Ok(school);
        }
    }
}