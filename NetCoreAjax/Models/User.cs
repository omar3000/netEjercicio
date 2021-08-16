using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetEjercicio.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public static class UserAction
    {
        private static List<User> users = new List<User>()
        {
            new User {Id = 1 , Name="nombre1"},
            new User {Id = 2 , Name="nombre2"}
        };

        public static List<User> GetAll()
        {
            return users;
        }

        public static User GetById(int id)
        {
            return users.FirstOrDefault(I => I.Id == id);
        }

        public static void Add(User user)
        {
            users.Add(user);
        }
    }
}
