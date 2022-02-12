using System;

namespace BookInheritanceAndOverride
{
    class Book
    {
        int bookid;
        string book_name, author_name;
        float price;

        public Book() { }
        public Book(int bookid, string book_name, string author_name, float price)
        {
            this.bookid = bookid;
            this.book_name = book_name;
            this.author_name = author_name;
            this.price = price;
        }

        public virtual void Display()
        {
            Console.WriteLine("Book Id: " + bookid + "\n" + "Book Name: " + book_name + "\n" + "Author Name: " + author_name + "\n" + "Price: " + price);
        }
    }

    class Reference_Book : Book
    {
        public Reference_Book() { }
        public Reference_Book(int bookid, string book_name, string author_name, float price) : base(bookid, book_name, author_name, price)
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("Reference Book Information: ");
            base.Display();
        }
    }

    class Magazine : Book
    {
        public Magazine() { }
        public Magazine(int bookid, string book_name, string author_name, float price) : base(bookid, book_name, author_name, price)
        {

        }
        public override void Display()
        {
            Console.WriteLine("Magazine Information: ");
            base.Display();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Reference Book
            Console.WriteLine("Enter Reference Book Id: ");
            int refbook_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Name: ");
            string refbook_name = Console.ReadLine();
            Console.WriteLine("Enter Author Name: ");
            string refbook_author = Console.ReadLine();
            Console.WriteLine("Enter Book Price: ");
            float price = float.Parse(Console.ReadLine());
            Reference_Book refbook_obj = new Reference_Book(refbook_id, refbook_name, refbook_author, price);
            refbook_obj.Display();
            Console.WriteLine("_______________________________________________________________________________________________________");

            //Magazine
            Console.WriteLine("Enter Magazine Id: ");
            int book_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Magazine Name: ");
            string book_name = Console.ReadLine();
            Console.WriteLine("Enter Author Name: ");
            string book_author = Console.ReadLine();
            Console.WriteLine("Enter Book Price: ");
            float price1 = float.Parse(Console.ReadLine());
            Magazine magazine_obj = new Magazine(book_id, book_name, book_author, price1);
            magazine_obj.Display();
        }
    }
}
