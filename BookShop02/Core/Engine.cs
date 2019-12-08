using BookShop02.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop02.Core
{
    public class Engine
    {
        public void Run()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(title, author, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(title, author, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(0);
            }
        
        }

    }
}
