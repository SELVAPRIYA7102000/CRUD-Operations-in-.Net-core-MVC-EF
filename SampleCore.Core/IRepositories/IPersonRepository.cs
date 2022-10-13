using SampleCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCore.Core.IRepositories
{
    public interface IPersonRepository
    {
       public void CreatePersonEntry(Person person);
        public void Delete(int person_id);
        public Person EditForm(int id);
        public void Update(int id, Person model);
        List<Person> Reads();
    }
  
}
