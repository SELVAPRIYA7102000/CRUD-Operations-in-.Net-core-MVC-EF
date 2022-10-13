using SampleCore.Core.IRepositories;
using SampleCore.Core.Model;
using SampleCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCore.Repositories.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public PersonDBContext entity;
        public PersonRepository(PersonDBContext persondbContext)
        {
            entity = persondbContext;
        }
        #region Create
        public void CreatePersonEntry(Core.Model.Person person)
        {
            if (person != null)
            {


                // Priya123Context entity = new Priya123Context();
                SampleCore.Entity.PersonDetails person1 = new SampleCore.Entity.PersonDetails();
                person1.Person_ID = person.Id;
                person1.First_Name = person.firstName;
                person1.Middle_Name = person.middleName;
                person1.Last_Name = person.lastName;

                person1.Course = person.course;
                person1.Gender = person.gender;
                person1.Phone = person.phone;
                person1.Email = person.email;
                person1.Address = person.address;
                person1.Password = person.password;
                person1.Retype_Password = person.retypePassword;
                person1.Created_Time_Stamp = DateTime.Now;
                person1.Updated_Time_Stamp = DateTime.Now;
                entity.Add(person1);
                entity.SaveChanges();
            }
        }
        #endregion

        
        #region Delete
        public void Delete(int person_id)
        {
            var data = entity.PersonDetails.Where(x => x.Person_ID == person_id).SingleOrDefault();
            data.Is_Deleted = true;
            entity.SaveChanges();
        }

        #endregion


        #region Edit
        public Person EditForm(int id)
        {
            Person pr = new Person();
            var data = entity.PersonDetails.Where(x => x.Person_ID == id).SingleOrDefault();
            pr.Id = data.Person_ID;
            pr.firstName = data.First_Name;
            pr.middleName = data.Middle_Name;
            pr.lastName = data.Last_Name;
            pr.gender = data.Gender;
            pr.course = data.Course;
            pr.phone = data.Phone;
            pr.address = data.Address;
            pr.email = data.Email;
            pr.password = data.Password;
            pr.retypePassword = data.Retype_Password;
            entity.SaveChanges();
            return pr;
        }
        public void Update(int id, Person model)
        {
            var data = entity.PersonDetails.Where(x => x.Person_ID == id).SingleOrDefault();
            if (data != null)
            {
                data.Person_ID = model.Id;
                data.First_Name = model.firstName;
                data.Middle_Name = model.middleName;
                data.Last_Name = model.lastName;
                data.Course = model.course;
                data.Gender = model.gender;
                data.Phone = model.phone;
                data.Address = model.address;
                data.Email = model.email;
                data.Password = model.password;
                data.Retype_Password = model.retypePassword;
                data.Created_Time_Stamp = DateTime.Now;
                data.Updated_Time_Stamp = DateTime.Now;
                entity.SaveChanges();
            }

        }

        #endregion

        #region Read
        public List<Person> Reads()
        {
            List<Person> model = new List<Person>();
            var data = entity.PersonDetails.Where(x => x.Is_Deleted == false).ToList();
            foreach (var item in data)
            {
                Person pers = new Person();
                pers.Id = item.Person_ID;
                pers.firstName = item.First_Name;
                pers.middleName = item.Middle_Name;
                pers.lastName = item.Last_Name;
                pers.course = item.Course;
                pers.gender = item.Gender;

                pers.phone = item.Phone;


                pers.email = item.Email;
                pers.address = item.Address;
                pers.password = item.Password;
                pers.retypePassword = item.Retype_Password;
                model.Add(pers);
            }
            return model;
        }
        #endregion

    }

}
