using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Users : Human
    {
        public string Password { get; set; }

        public string NationalID { get; set; }
        public List<Users> getAllUser()
        {
            List<Users> user = new List<Users>
            {
                new Users { Name = "Mahesh Chand", Password = "123", Age = 17,Gender = 1 ,NationalID = "123123432", ID =1,Family = "fdsa" },
                new Users { Name = "Ali", Password = "456", Age = 17, Gender = 2 , NationalID = "4329054898" , ID = 2,Family = "hgfd"},
                new Users { Name = "Safar", Password = "789", Age = 17 , Gender = 2 , NationalID = "49289421432", ID = 3, Family = "hfd"},

            };
            return user;
        }
    }
}
