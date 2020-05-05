using System;
using System.Collections.Generic;
using System.Text;

namespace Eleva.Domain.Models
{
    public class Address : Entity
    {
        public string PublicPlace { get; set; }
        public string Complement { get; set; }
        public string Number { get; set; }
        public string Zipcode { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Guid SchoolId { get; set; }
        public School School { get; set; }
    }
}
