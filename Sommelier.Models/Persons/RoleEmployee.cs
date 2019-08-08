using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Models.Persons
{
    public class RoleEmployee : BaseEntity
    {
        public Employee Employee { get; set; }
        public EmployeeRole CurrentRole { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<RoleEmployee> History { get; set; }
    }
}
