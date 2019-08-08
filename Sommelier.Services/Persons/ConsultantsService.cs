using System;
using System.Collections.Generic;
using System.Text;
using Sommelier.Models.Persons;
using Sommelier.Repositories;

namespace Sommelier.Services.Persons
{
    public class ConsultantsService : IConsultantsService
    {
        private readonly IRepository<Consultant> consultantRepo;

        public ConsultantsService(IRepository<Consultant> consultantRepo)
        {
            this.consultantRepo = consultantRepo;
        }

        public Consultant CreateConsultant(Consultant c)
        {
            return this.consultantRepo.Create(c);
        }

        public void DeleteConsultant(Consultant c)
        {
            this.consultantRepo.Delete(c);
        }

        public IEnumerable<Consultant> GetAllConsultants()
        {
            return this.consultantRepo.GetAll();
        }

        public Consultant GetConsultantById(Guid id)
        {
            return this.consultantRepo.GetById(id);
        }

        public void UpdateConsultant(Consultant c)
        {
            throw new NotImplementedException();
        }
    }
}
