

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace c_sharp_DeskLibrary
{
    class User
    {
        public string ID { get; }
        public string Username { get; }
        public string DirectoryPath { get; set; }


        public User(string username)
        {
            Username = username;
            ID = Guid.NewGuid().ToString();
            DirectoryPath = getDirectoryPath();
        }


        private string getDirectoryPath()
        {
           var str = AppDomain.CurrentDomain.BaseDirectory + $@"Profiles\{Username}";//Assembly.GetExecutingAssembly().Location;

            if (!Directory.Exists(DirectoryPath)) // Путь
            {
                Directory.CreateDirectory(DirectoryPath); // Если нет - создаем
            }

            return str;
            //MessageBox.Show(UserDirectoryPath);
        }
    }
}
