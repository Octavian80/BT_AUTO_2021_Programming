using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Author
    {
        string nameAuthor;
        string email;

        public Author(string nameAuthor, string email)
        {
            this.nameAuthor = nameAuthor;
            this.email = email;
        }

        public Author()
        {
        }

        public virtual string  GetName()
        {
            return this.nameAuthor;
        }
        public string GetEmail()
        {
            return this.email;
        }

       
    }
}
