using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary
{
    public class Service : IService
    {
        private DB context = new DB();

        public List<Person> GetDict()
        {
            return context.GetAll();
        }

        public void AddDict(Person person)
        {
            context.AddPhone(person);
        }

        public void UpdDict(Person person)
        {
            context.UpdatePhone(person);
        }

        public void DelDict(Person person)
        {
            context.DeletePhone(person);
        }
    }
}
