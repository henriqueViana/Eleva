using AutoMapper;
using Eleva.Application.DTO;
using Eleva.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Domain.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IMapper _mapper;
        private readonly ISchoolRepository _schoolRepository;

        public SchoolService(IMapper mapper, ISchoolRepository schoolRepository)
        {
            _mapper = mapper;
            _schoolRepository = schoolRepository;
        }

        public async Task<IEnumerable<SchoolDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<SchoolDTO>>(await _schoolRepository.GetAll()); 
        }

        public SchoolDTO GetById(Guid id)
        {
            return _mapper.Map<SchoolDTO>(_schoolRepository.GetById(id));
        }
    }
}
