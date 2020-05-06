using Eleva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Domain.Interfaces
{
    interface IStudentClassService
    {
        Task<IEnumerable<StudentClassDTO>> GetAll();
        Task<StudentClassDTO> GetById(Guid id);
        Task<bool> Create(StudentClassDTO schoolDTO);
        Task<bool> Update(StudentClassDTO schoolDTO);
        Task<bool> Destroy(Guid id);
    }
}
