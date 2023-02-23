using System;
using System.Collections.Generic;

namespace SQLTelephoneDictionaryDLL
{
    public interface IPhoneDictionary
    {
        List<Person> GetAll();
        void AddPhone(Person person);
        void UpdatePhone(Person person);
        void DeletePhone(Person person);
    }
}
