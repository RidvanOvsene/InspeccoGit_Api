using Business.Services.Interfeces;
using DataAccess.Repositories.Interfaces;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;
        public PersonService(IPersonRepository PersonRepository)
        {
            _personRepository = PersonRepository;
        }

        public Person GetById(int Id)
        {
            return _personRepository.Get(a => a.PersonId == Id);
        }

        public List<Person> GetList()
        {
            return _personRepository.GetList().ToList();
        }
        public List<Entities.Dtos.PersonDto> GetListPersonDto()
        {
            return new List<Entities.Dtos.PersonDto>(_personRepository.GetListPersonDto().ToList());
        }
        public string Add(Person person)
        {
            _personRepository.Add(person);
            return "Ok";
        }
        public string Update(Person person)
        {
            _personRepository.Update(person);
            return "Ok";
        }
        public string Delete(Person person)
        {
            _personRepository.Delete(person);
            return "Ok";
        }

        public object GetById()
        {
            throw new NotImplementedException();
        }
    }
}