using Sommelier.Models.Accounts;
using Sommelier.Models.Contracts;
using Sommelier.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sommelier.Repositories.Persons
{
    public class ConsultantsRepository : IRepository<Consultant>
    {
        List<Consultant> consultants;

        public ConsultantsRepository()
        {
            this.consultants = new List<Consultant>();
            var tomConsultant = new Consultant()
            {
                Id = Guid.NewGuid(),
                FirstName = "Tom",
                LastName = "Demey",
                BirthDate = new DateTime(1995, 11, 19),
                Contract = new ElmosContract()
                {
                    Id = Guid.NewGuid(),
                    ContractType = ContractType.Freelance,
                    Salary = 2200.46
                },
                Accounts = new List<Account>()
                {
                    new Account()
                    {
                        Id = Guid.NewGuid(),
                        ProjectName = "FullStackOpleidingAugustus",
                        ProjectDescription = "Full stack opleiding onder begeleiding van Kevin Deruddere"
                    }
                }
            };
            var tomContract = new ElmosContract()
            {
                Id = Guid.NewGuid(),
                ContractType = ContractType.InHouse,
                Salary = 2200.46,
                Person = tomConsultant
            };
            var tomAccounts = new List<Account>()
            {
                new Account()
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "FullStackOpleidingAugustus",
                    ProjectDescription = "Full stack opleiding onder begeleiding van Kevin Deruddere"
                }
            };
            //tomConsultant.Contract = tomContract;
            //tomConsultant.Accounts = tomAccounts;
            this.consultants.Add(tomConsultant);

            var kevinConsultant = new Consultant()
            {
                Id = Guid.NewGuid(),
                FirstName = "Kevin",
                LastName = "Deruddere",
                BirthDate = new DateTime(1982, 11, 19),
                Contract = new ElmosContract()
                {
                    Id = Guid.NewGuid(),
                    ContractType = ContractType.Freelance,
                    Salary = 2900.46
                },
                Accounts = new List<Account>()
                {
                    new Account()
                    {
                        Id = Guid.NewGuid(),
                        ProjectName = "FullStackOpleidingAugustus",
                        ProjectDescription = "Full stack opleiding onder begeleiding van Kevin Deruddere"
                    },
                    new Account()
                    {
                    Id = Guid.NewGuid(),
                    ProjectName = "KBC bank Rework webapp",
                    ProjectDescription = "Het herdesignen van de webapplicatie van KBC"
                    }
                }
            };
            var kevinContract = new ElmosContract()
            {
                Id = Guid.NewGuid(),
                ContractType = ContractType.Freelance,
                Salary = 2900.46,
                Person = kevinConsultant
            };
            var kevinAccounts = new List<Account>()
            {
                new Account()
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "FullStackOpleidingAugustus",
                    ProjectDescription = "Full stack opleiding onder begeleiding van Kevin Deruddere"
                },
                new Account()
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "KBC bank Rework webapp",
                    ProjectDescription = "Het herdesignen van de webapplicatie van KBC"
                }
            };
            //kevinConsultant.Contract = kevinContract;
            //kevinConsultant.Accounts = kevinAccounts;
            this.consultants.Add(kevinConsultant);

        }

        public Consultant Create(Consultant entity)
        {
            this.consultants.Add(entity);
            return entity;
        }

        public void Delete(Consultant entity)
        {
            this.consultants.Remove(entity);
        }

        public IEnumerable<Consultant> GetAll()
        {
            return this.consultants;
        }

        public Consultant GetById(Guid id)
        {
            var consultant = from p in this.consultants
                             where p.Id == id
                             select p;
            return consultant.FirstOrDefault();

            //return this.consultants.Where(c => c.Id == id).SingleOrDefault();
        }

        public void Update(Consultant entity)
        {
            throw new NotImplementedException();
        }
    }
}
