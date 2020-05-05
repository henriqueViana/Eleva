using System;
using System.Collections.Generic;
using System.Text;

namespace Eleva.Domain.Models
{
    public class StudentClass : Entity
    {
        public string NumberClass { get; set; }
        public int Workload { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        public Guid SchoolId { get; set; }
        public School School { get; set; }
    }
}
