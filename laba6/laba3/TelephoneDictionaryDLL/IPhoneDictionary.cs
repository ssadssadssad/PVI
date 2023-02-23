using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDictionaryDLL
{
    public interface IPhoneDictionary
    {
        List<Person> GetAll();
        void AddPhone(Person person);
        void UpdatePhone(Person person);
        void DeletePhone(Person person);
    }
}
