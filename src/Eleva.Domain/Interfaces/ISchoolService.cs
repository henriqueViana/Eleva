using Eleva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eleva.Domain.Interfaces
{
    public interface ISchoolService
    {
        IEnumerable<SchoolDTO> GetAll();
        SchoolDTO GetById(Guid id);
       
    }
}
