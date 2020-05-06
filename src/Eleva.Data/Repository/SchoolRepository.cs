using Eleva.Data.Context;
using Eleva.Domain.Interfaces;
using Eleva.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eleva.Data.Repository
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        public SchoolRepository(ElevaDbContext context) : base(context) { }

        public async Task<School> GetSchoolAndAddress(Guid id)
        {
            return await _context.Schools.AsNoTracking()
                .Include(column => column.Address)
                .FirstOrDefaultAsync(column => column.Id == id);
        }

        public async Task<School> GetSchoolAndAddressAndStudentClass(Guid id)
        {
            return await _context.Schools.AsNoTracking()
                .Include(column => column.Address)
                .Include(column => column.StudentClasses)
                .FirstOrDefaultAsync(column => column.Id == id);
        }
    }
}
