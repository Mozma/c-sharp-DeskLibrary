using System;


namespace c_sharp_DeskLibrary
{
    [Serializable]
    public class Book
    {
        #region Свойства
        /// <summary>
        /// Название произведения или книги.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// ФИО автора.
        /// </summary>
        public string Author { get; }
        /// <summary>
        /// Уникальный код книги.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Статус книги.
        /// </summary>
        public string Status { get; set; }
        #endregion

        public Book(string name, string author)
        {
            #region Проверки
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название книги не может быть пустым или null.", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentNullException("ФИО автора не может быть пустым или null.", nameof(author));
            }
            #endregion

            Name = name;
            Author = author;
            Id = Guid.NewGuid().ToString();
            Status = "In Library";
        }


        public override string ToString()
        {
            return $"{Author} \"{Name}\" - {Status} : {Id}";
        }
    }
}
