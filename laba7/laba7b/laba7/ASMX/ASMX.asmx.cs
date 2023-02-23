using Lab7a.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASMX
{
    /// <summary>
    /// Сводное описание для ASMX
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class ASMX : System.Web.Services.WebService
    {
        private DB context = new DB();

        [WebMethod(Description = "Get dict", EnableSession = true)]
        public List<Person> GetDict()
        {
            return context.GetAll();
        }

        [WebMethod(Description = "Add dict", EnableSession = true)]
        public void AddDict(Person person)
        {
            context.AddPhone(person);
        }

        [WebMethod(Description = "Update dict", EnableSession = true)]
        public void UpdDict(Person person)
        {
            context.UpdatePhone(person);
        }

        [WebMethod(Description = "Delete dict", EnableSession = true)]
        public void DelDict(Person person)
        {
            context.DeletePhone(person);
        }
    }
}
