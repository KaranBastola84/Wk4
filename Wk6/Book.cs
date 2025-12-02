namespace Wk4.Wk6
{
    // Book class for filtering example
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            return $"'{Title}' by {Author} - Rs. {Price}";
        }
    }
}
