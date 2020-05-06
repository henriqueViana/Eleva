using Eleva.Data.Context;
using Eleva.Domain.Interfaces;
using Eleva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eleva.Data.Repository
{
    public class StudentClassRepository : Repository<StudentClass>, IStudentClassRepository 
    {
        public StudentClassRepository(ElevaDbContext context) : base(context) { }


    }
}
