using Sommelier.Models.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Models.Contracts
{
    public class ElmosContract : BaseEntity
    {
        public Person Person { get; set; }
        public double Salary { get; set; }
        public ContractType ContractType { get; set; }
    }
}
