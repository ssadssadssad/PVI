using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace laba3.Models
{
    public class Methods
    {
        public List<User> GetAll()
        {
            using (StreamReader fs = new StreamReader(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Dict.json")))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                List<User> listUser = serializer.Deserialize<List<User>>(fs.ReadToEnd());
                return listUser;
            }
        }

        public void AddPhone(User user)
        {
            List<User> listUser = GetAll();
            listUser.Add(user);
            using (StreamWriter fs = new StreamWriter(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Dict.json"), false))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(listUser);
                fs.Write(json);
            }
        }

        public void UpdatePhone(User user)
        {
            List<User> listUser = GetAll();
            foreach (var x in listUser)
            {
                if (x.Name == user.Name)
                {
                    x.Phone = user.Phone;
                    ;
                }
            }
            using (StreamWriter fs = new StreamWriter(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Dict.json"), false))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(listUser);
                fs.Write(json);
            }
        }

        public void DeletePhone(User user)
        {
            List<User> listUser = GetAll();
            List<User> newListUser = new List<User>();
            foreach (var x in listUser)
            {
                if (x.Phone != user.Phone)
                {
                    newListUser.Add(x);
                }
            }
            using (StreamWriter fs = new StreamWriter(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Dict.json"), false))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(newListUser);
                fs.Write(json);
            }
        }
    }
}