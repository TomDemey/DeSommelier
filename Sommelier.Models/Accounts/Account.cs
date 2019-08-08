using Sommelier.Models.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Models.Accounts
{
    public class Account : BaseEntity
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public IList<Consultant> Consultants { get; set; }
    }
}
