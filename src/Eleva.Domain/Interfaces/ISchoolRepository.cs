using Eleva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Domain.Interfaces
{
    public interface ISchoolRepository : IRepository<School>
    {
        Task<School> GetSchoolAndAddress(Guid id);
        Task<School> GetSchoolAndAddressAndStudentClass(Guid id);
    }
}
