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
    public class StudentClassService : Service, IStudentClassService 
    {
        private readonly IMapper _mapper;
        private readonly IStudentClassRepository _studentClassRepository;

        public StudentClassService(IMapper mapper, IStudentClassRepository studentClassRepository)
        {
            _mapper = mapper;
            _studentClassRepository = studentClassRepository;
        }

        public async Task<IEnumerable<StudentClass>> GetAll()
        {
            // return _mapper.Map<IEnumerable<StudentClassDTO>>(await _studentClassRepository.GetAll());
            return await _studentClassRepository.GetAll();
        }

        public async Task<StudentClass> GetById(Guid id)
        {
            // return _mapper.Map<StudentClassDTO>(await _studentClassRepository.GetById(id));
            return await _studentClassRepository.GetById(id);
        }

        public async Task<bool> Create(StudentClass studentClass)
        {
            //var studentClass = _mapper.Map<StudentClass>(studentClassDTO);

            var studentClassIsValid = Validade(new StudentClassValidation(), studentClass);

            if (!studentClassIsValid) return false;

            await _studentClassRepository.Create(studentClass);
            return true;
        }

        public async Task<bool> Update(StudentClass studentClass)
        {
            // var studentClass = _mapper.Map<StudentClass>(studentClassDTO);

            var studentClassIsValid = Validade(new StudentClassValidation(), studentClass);

            if (!studentClassIsValid) return false;

            await _studentClassRepository.Update(studentClass);
            return true;
        }

        public async Task<bool> Destroy(Guid id)
        {
            await _studentClassRepository.Destroy(id);
            return true;
        }
    }
}
