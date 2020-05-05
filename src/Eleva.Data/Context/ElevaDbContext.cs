using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Eleva.Domain.Models;

namespace Eleva.Data.Context
{
    public class ElevaDbContext : DbContext
    {
        public ElevaDbContext(DbContextOptions<ElevaDbContext> options) : base(options) { }

        public DbSet<School> Schools { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }

        
    }
}
