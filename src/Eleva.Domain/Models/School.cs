using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Eleva.Domain.Models
{
    public class School : Entity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public Address Address { get; set; }
        public IEnumerable<StudentClass> StudentClasses { get; set; }
    }
}
