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

        public async Task<IEnumerable<StudentClassDTO>> GetAll()
        {
            var st = await _studentClassRepository.GetAll();
            if (st == null)
            {

            }

            var mp = _mapper.Map<IEnumerable<StudentClassDTO>>(await _studentClassRepository.GetAll());
            if (mp == null)
            {

            }

            return _mapper.Map<IEnumerable<StudentClassDTO>>(await _studentClassRepository.GetAll());
        }

        public async Task<StudentClassDTO> GetById(Guid id)
        {
            return _mapper.Map<StudentClassDTO>(await _studentClassRepository.GetById(id));
        }

        public async Task<bool> Create(StudentClassDTO studentClassDTO)
        {
            var studentClass = _mapper.Map<StudentClass>(studentClassDTO);

            var studentClassIsValid = Validade(new StudentClassValidation(), studentClass);

            if (!studentClassIsValid) return false;

            await _studentClassRepository.Create(studentClass);
            return true;
        }

        public async Task<bool> Update(StudentClassDTO studentClassDTO)
        {
            var studentClass = _mapper.Map<StudentClass>(studentClassDTO);

            var studentClassIsValid = Validade(new StudentClassValidation(), studentClass);

            if (!studentClassIsValid) return false;

            await _studentClassRepository.Update(studentClass);
            return true;
        }

        public async Task<bool> Destroy(Guid id)
        {
            var studentClass = await _studentClassRepository.GetById(id);

            if (studentClass == null) return false;

            await _studentClassRepository.Destroy(id);
            return true;
        }
    }
}
