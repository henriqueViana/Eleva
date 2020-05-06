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
        public async Task<IEnumerable<StudentClassDTO>> GetAll()
        {
            return await _studentClassService.GetAll();
        }
    }
}