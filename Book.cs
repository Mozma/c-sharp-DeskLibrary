using System;


namespace c_sharp_DeskLibrary
{
    [Serializable]
    public class Book
    {
        public string Name { get; }
        public string Author { get; }
        public string Id { get; }
        public string Status { get; set; }
        
        public Book(string name, string author)
        {
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
