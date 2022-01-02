using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Book: Author
    {
        string name;
        int year;
        double price;
        Author autor;

        
        public Book(string name, int year, double price, Author autor)
        {
            this.name = name;
            this.year = year;
            this.price = price;
            this.autor = autor;

        }

        public Book()
        {

        }

        public override string GetName()
        {
            return this.name;
        }

        public double GetPrice ()
        {
             return this.price;
            
        }

        public string GetAuthor()
        {
            return autor.GetName();
        }

        public int GetYear()
        {
           return  this.year;
        }
            
    }
}
