using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int AutherID { get; set; }
        public double Price { get; set; }
        public string Gener { get; set; }
        public List<Books> book()
        {
            List<Books> bookList = new List<Books>()
            {
                new Books() { BookID = 1,BookName = "aaaa" , AutherID= 1 , Gener = "roman",Price= 1.42},
                new Books() { BookID = 2,BookName = "fdsa" , AutherID= 2 , Gener = "horror",Price= 2.42},
                new Books() { BookID = 3,BookName = "trew" , AutherID= 3 , Gener = "comedy",Price= 3.52},
                new Books() { BookID = 4,BookName = "fghsh" , AutherID= 4 , Gener = "action",Price= 1.94},
            };
            return bookList;
        }
    }
}
