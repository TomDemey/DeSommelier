using Sommelier.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Models.Persons
{
    public class Consultant :  Person
    {
        public IList<Account> Accounts { get; set; }
    }
}
