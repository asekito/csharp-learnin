using System;

namespace csharp_learnin
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Song of Achilles";
            book1.author = "Can't remember";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of The Flies";
            book2.author = "Still Can't Remember";
            book2.pages = 100;

            Console.WriteLine(book2.title + ' ' + book1.pages);
        }
    }
}