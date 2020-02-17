using System;
using System.IO;


namespace c_sharp_DeskLibrary
{
    [Serializable]
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

            if (!Directory.Exists(str)) // Путь
            {
                Directory.CreateDirectory(str); // Если нет - создаем
            }

            return str;
            //MessageBox.Show(UserDirectoryPath);
        }
    }
}
