using Eleva.Application.DTO;
using Eleva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Domain.Interfaces
{
    public interface ISchoolService
    {
        Task<IEnumerable<School>> GetAll();
        Task<School> GetById(Guid id);
        Task<bool> Create(School school); 
        Task<bool> Update(School school);
        Task<bool> Destroy(Guid id);

    }
}
