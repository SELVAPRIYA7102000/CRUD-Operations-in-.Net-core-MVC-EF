


using SampleCore.Core.IRepositories;
using SampleCore.Core.IServices;
using SampleCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCore.Service.Services
{
    public class PersonServices : IPersonServices
    {
        private readonly IPersonRepository _personRepository;

        public PersonServices(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public void CreatePersonEntry(Person person)
        {
            //business condition
            if (person.firstName!= string.Empty && person.firstName != string.Empty)
            {
                _personRepository.CreatePersonEntry(person);
            }
        }
        public void Delete(int person_id)
        {
            _personRepository.Delete(person_id);
        }
        public Person EditForm(int id)
        {
           return _personRepository.EditForm(id);
           
        }
        public void Update(int id, Person model)
        {
            _personRepository.Update(id, model);

        }
       public List<Person> Reads()
        {
           return  _personRepository.Reads();
        }
    }
}
