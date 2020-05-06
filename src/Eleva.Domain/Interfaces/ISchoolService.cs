using Eleva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Domain.Interfaces
{
    public interface ISchoolService
    {
        Task<IEnumerable<SchoolDTO>> GetAll();
        SchoolDTO GetById(Guid id);
       
    }
}
