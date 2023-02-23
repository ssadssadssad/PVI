using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace TelephoneDictionaryDLL
{
    public class DB : IPhoneDictionary
    {
        private static string path = @"D:\ФИТ\4ый курс\1ый семестр\Internet\Лабораторные\lab6\laba3\laba3\App_Data\Dict.json";
        public List<Person> GetAll()
        {
            using (StreamReader fs = new StreamReader(path))
            {                
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                List<Person> listPerson = serializer.Deserialize<List<Person>>(fs.ReadToEnd());
                return listPerson;
            }
        }
        public void AddPhone(Person person)
        {
            List<Person> listPerson = GetAll();
            listPerson.Add(person);
            using (StreamWriter fs = new StreamWriter(path, false))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(listPerson);
                fs.Write(json);
            }
        }
        public void UpdatePhone(Person person)
        {
            List<Person> listPerson = GetAll();
            foreach (var x in listPerson)
            {
                if (x.Name == person.Name)
                {
                    x.Phone = person.Phone;
                }
            }
            using (StreamWriter fs = new StreamWriter(path, false))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(listPerson);
                fs.Write(json);
            }
        }
        public void DeletePhone(Person person)
        {
            List<Person> listPerson = GetAll();
            List<Person> newListPerson = new List<Person>();
            foreach (var x in listPerson)
            {
                if (x.Phone != person.Phone)
                {
                    newListPerson.Add(x);
                }
            }
            using (StreamWriter fs = new StreamWriter(path, false))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(newListPerson);
                fs.Write(json);
            }
        }
    }
}
