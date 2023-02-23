using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTelephoneDictionary
{
    public class DB : IPhoneDictionary
    {
        public static PersonContext Db { get; set; }
        public DB()
        {
            Db = new PersonContext();
        }
        public List<Person> GetAll()
        {
            List<Person> listPerson = new List<Person>();
            foreach (var person in Db.People)
            {
                listPerson.Add(person);
            }
            return listPerson;
        }

        public void AddPhone(Person person)
        {
            Db.People.Add(person);
            Db.SaveChanges();
        }

        public void UpdatePhone(Person person)
        {
            foreach (var pers in Db.People)
            {
                if (pers.Name == person.Name)
                {
                    pers.Phone = person.Phone;
                    break;
                }
            }
            Db.SaveChanges();
        }

        public void DeletePhone(Person person)
        {
            foreach (var pers in Db.People)
            {
                if (pers.Name == person.Name)
                {
                    Db.People.Remove(pers);
                    break;
                }
            }
            Db.SaveChanges();
        }
    }
}