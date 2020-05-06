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
    }
}