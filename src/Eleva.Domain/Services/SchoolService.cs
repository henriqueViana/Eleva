using AutoMapper;
using Eleva.Application.DTO;
using Eleva.Domain.Interfaces;
using Eleva.Domain.Models;
using Eleva.Domain.Models.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Domain.Services
{
    public class SchoolService : Service, ISchoolService
    {
        private readonly IMapper _mapper;
        private readonly ISchoolRepository _schoolRepository;
        private readonly IAddressRepository _addressRepository;

        public SchoolService(
            IMapper mapper, ISchoolRepository schoolRepository, IAddressRepository addressRepository)
        {
            _mapper = mapper;
            _schoolRepository = schoolRepository;
            _addressRepository = addressRepository;
        }

        public async Task<IEnumerable<SchoolDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<SchoolDTO>>(await _schoolRepository.GetAll());
        }

        public async Task<SchoolDTO> GetById(Guid id)
        {
            return _mapper.Map<SchoolDTO>(await _schoolRepository.GetSchoolAndAddressAndStudentClass(id));
        }

        public async Task<bool> Create(SchoolDTO schoolDTO)
        {
            var school = _mapper.Map<School>(schoolDTO);

            var schoolIsValid = Validade(new SchoolValidation(), school);
            var addressIsValid = Validade(new AddressValidation(), school.Address);

            if (!schoolIsValid || addressIsValid) return false;

            await _schoolRepository.Create(school);
            return true;
        }

        public async Task<bool> Update(SchoolDTO schoolDTO)
        {
            var school = _mapper.Map<School>(schoolDTO);
            var schoolIsValid = Validade(new SchoolValidation(), school);

            if (!schoolIsValid) return false;

            await _schoolRepository.Update(school);
            return true;
        }

        public async Task<bool> Destroy(Guid id)
        {
            // verificar se tem turmas relacionadas

            var address = await _addressRepository.GetAddressBySchoolId(id);

            if (address != null)
            {
                await _addressRepository.Destroy(id);
            } 

            await _schoolRepository.Destroy(id);
            return true;
        }
    }
}
