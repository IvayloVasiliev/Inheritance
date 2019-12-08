using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop02.Books
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Title
        {
            get => title; 
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }
        public string Author
        {
            get => author; 
            set
            {
                bool containsNumber = value.Any(char.IsDigit);
                if (containsNumber)
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }
        public virtual decimal Price
        {
            get => price; 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {GetType().Name}")
            .AppendLine($"Title: {Title}")
            .AppendLine($"Author: {Author}")
            .AppendLine($"Price: {Price:f2}");

            return sb.ToString();
        }

    }
}
