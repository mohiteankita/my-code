using System;

namespace BookClass
{
    public class Book
    {
        int bookid, discount;
        string book_name, author_name;
        float price;

        public Book(int bookid, string book_name, string author_name, float price)
        {
            this.bookid = bookid;
            this.book_name = book_name;
            this.author_name = author_name;
            this.price = price;
        }

        //Calculate 10% of discount
        public void CalculateDiscount()
        {
            price = price - (price * 10/100);
        }

        public override string ToString()
        {
            return "Book id= " + bookid + "\nBook Name= " + book_name + "\nAuthor Name= " + author_name + "\nBook Price= " + price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book(121, "A pair of blue eyes", "Thomas Hardy", 240.9f);
            b.CalculateDiscount();
            Console.WriteLine(b);
        }
    }
}
