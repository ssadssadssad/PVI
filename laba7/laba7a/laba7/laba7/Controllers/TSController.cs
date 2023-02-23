using laba7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace laba7.Controllers
{
    public class TSController : ApiController
    {
        private static DB context = new DB();

        public IEnumerable<Person> GetAll()
        {
            return context.GetAll();
        }

        [HttpPost]
        public void AddPerson([FromBody] Person person)
        {
            context.AddPhone(person);
        }

        [HttpPut]
        public void UpdatePerson([FromBody] Person person)
        {
            context.UpdatePhone(person);
        }

        [HttpDelete]
        public void DeletePerson([FromBody] Person person)
        {
            context.DeletePhone(person);
        }
    }
}
