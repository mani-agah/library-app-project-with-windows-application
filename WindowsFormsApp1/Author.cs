using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Author:Human
    {
        public List<Author> Authors()
        {
            List<Author> authorList = new List<Author>()
            {
                new Author() {Name ="ljkh",Age = 32, Gender = 1, ID = 1},
                new Author() {Name ="yrte",Age = 31, Gender = 2, ID = 8},
                new Author() {Name ="jhgf",Age = 65, Gender = 2, ID = 6},
                new Author() {Name ="rewq",Age = 42, Gender = 1, ID = 3},
                new Author() {Name ="fdsa",Age = 32, Gender = 1, ID = 2},
            };
            return authorList;
        }

    }
}
