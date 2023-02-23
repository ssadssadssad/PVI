using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba4.Models
{
    public class DB
    {
        public UserContext Db { get; set; }
        public DB()
        {
            Db = new UserContext();
        }
        public List<User> GetAll()
        {
            List<User> listUser = new List<User>();
            foreach (var user in Db.People)
            {
                listUser.Add(user);
            }
            return listUser;
        }

        public void AddPhone(User user)
        {
            Db.People.Add(user);
            Db.SaveChanges();
        }

        public void UpdatePhone(User user)
        {
            foreach (var us in Db.People)
            {
                if (us.Name == user.Name)
                {
                    us.Phone = user.Phone;
                    break;
                }
            }
            Db.SaveChanges();
        }

        public void DeletePhone(User user)
        {
            foreach (var us in Db.People)
            {
                if (us.Name == user.Name)
                {
                    Db.People.Remove(us);
                    break;
                }
            }
            Db.SaveChanges();
        }
    }
}