using Sommelier.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Models.Persons
{
    public class Employee : Person
    {
        public IList<EmployeeRole> Roles { get; set; }
        public IList<Account> Accounts { get; set; }
    }
}
