

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace c_sharp_DeskLibrary
{
    class Profile
    {
        public string ID { get; }
        public string Username { get; }
        public string DirectoryPath { get; set; }


        public Profile(string username)
        {
            Username = username;
            ID = Guid.NewGuid().ToString();

            DirectoryPath = AppDomain.CurrentDomain.BaseDirectory  + $@"Profiles\{Username}";//Assembly.GetExecutingAssembly().Location;

            if (!Directory.Exists(DirectoryPath)) // Путь
            {
                Directory.CreateDirectory(DirectoryPath); // Если нет - создаем
            }

            //MessageBox.Show(UserDirectoryPath);
        }
    }
}
