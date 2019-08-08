using Sommelier.Models.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Models.Accounts
{
    public class AccountConsultant : BaseEntity
    {
        public Account Account { get; set; }
        public Consultant Consultant { get; set; }
        public double HourlyRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
