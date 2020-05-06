using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eleva.Application.DTO;
using Eleva.Domain.Interfaces;
using Eleva.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eleva.WebApi.Controllers
{
    [Route("api/turmas")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        private readonly IStudentClassService _studentClassService;

        public StudentClassController(IStudentClassService studentClassService)
        {
            _studentClassService = studentClassService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentClass>>> GetAll()
        {
            return Ok(await _studentClassService.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<StudentClass>> GetById(Guid id)
        {
            var studentClass = await _studentClassService.GetById(id);

            if (studentClass == null) return NotFound();

            return Ok(studentClass);
        }

        [HttpPost]
        public async Task<ActionResult<StudentClass>> Create(StudentClass studentClass)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = await _studentClassService.Create(studentClass);

            if (!result) return BadRequest();

            return Ok(studentClass);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<StudentClass>> Update(Guid id, StudentClass studentClass)
        {
            if (studentClass.Id != id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var result = await _studentClassService.Update(studentClass);

            if (!result) return BadRequest();

            return Ok(studentClass);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> Destroy(Guid id)
        {
            var result = await _studentClassService.Destroy(id);

            return Ok(result);
        }
    }
}