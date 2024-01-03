namespace AssignmentApiBook.Models
{
    public class Book
    {
       public int BookId {  get; set; } 
        public string BookName { get; set; }

        public int Price { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string Publiser { get; set; }
        public int Ryear { get; set; }
    }
}

