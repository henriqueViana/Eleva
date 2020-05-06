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
        Task<SchoolDTO> GetById(Guid id);
        Task<bool> Create(SchoolDTO schoolDTO); 
        Task<bool> Update(SchoolDTO schoolDTO);
        Task<bool> Destroy(Guid id);

    }
}
