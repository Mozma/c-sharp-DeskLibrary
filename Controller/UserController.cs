using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_DeskLibrary.Controller
{
    class UserController
    { 
        public List<User> Users { get; }
        public User CurrentUser { get; }
 



        public UserController(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(userName));
            }


            Users = GetUsersData();
            CurrentUser = Users.SingleOrDefault(u => u.Username == userName);

            if (CurrentUser == null)
            {
                CurrentUser = new User(userName);
                Users.Add(CurrentUser);

                Save();
            }
        }
        /// <summary>
        /// Получение данных о пользователях.
        /// </summary>
        /// <returns></returns>
        private List<User> GetUsersData()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {

                if (formatter.Deserialize(fs) is List<User> users)
                {
                    return users;
                }
                else
                {
                    return new List<User>();
                }

            }
        }

        /// <summary>
        /// Сохранение данных о пользователях.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);
            }

            return true;
        }
    }
}
