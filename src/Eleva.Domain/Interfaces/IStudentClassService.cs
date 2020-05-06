using Eleva.Application.DTO;
using Eleva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Domain.Interfaces
{
    public interface IStudentClassService
    {
        Task<IEnumerable<StudentClass>> GetAll();
        Task<StudentClass> GetById(Guid id);
        Task<bool> Create(StudentClass school);
        Task<bool> Update(StudentClass school);
        Task<bool> Destroy(Guid id);
    }
}
