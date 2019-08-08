using Sommelier.Models.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Services.Persons
{
    public interface IConsultantsService
    {
        IEnumerable<Consultant> GetAllConsultants();
        Consultant GetConsultantById(Guid id);
        Consultant CreateConsultant(Consultant c);
        void UpdateConsultant(Consultant c);
        void DeleteConsultant(Consultant c);
    }
}
