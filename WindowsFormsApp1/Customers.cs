using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Customers : Human
    {
        public DateTime OrderTime { get; set; }
        public List<Customers> customer()
        {
            List<Customers> customer = new List<Customers>()
            {
                new Customers() {Name = "fdaskjf",Family = "hjfdd" ,Age = 32,Gender = 1,ID = 1,OrderTime = Convert.ToDateTime("2022-01-01")},
                new Customers() {Name = "fdaskjf",Family = "gsdaw" ,Age = 32,Gender = 1,ID = 1,OrderTime = Convert.ToDateTime("2021-03-02")},
                new Customers() {Name = "fdaskjf",Family = "hdfhd" ,Age = 32,Gender = 1,ID = 1,OrderTime = Convert.ToDateTime("2023-06-03")},
                new Customers() {Name = "fdaskjf",Family = "fsdag" ,Age = 32,Gender = 1,ID = 1,OrderTime = Convert.ToDateTime("2020-07-04")},

            };
            return customer;
        }
    }
}
