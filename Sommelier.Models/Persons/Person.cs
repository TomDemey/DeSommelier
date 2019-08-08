using Sommelier.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Models.Persons
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ElmosContract Contract { get; set; }
    }
}
