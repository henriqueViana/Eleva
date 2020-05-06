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
    class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(ElevaDbContext context) : base(context) { }

        public async Task<Address> GetAddressBySchoolId(Guid schoolId)
        {
            return await _context.Addresses.AsNoTracking()
                .FirstOrDefaultAsync(column => column.SchoolId == schoolId);
        }
    }
}
