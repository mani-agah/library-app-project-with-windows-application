using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Publishers : Human
    {
        public string PublisherCountry { get; set; }
        public List<Publishers> allPublisher()
        {
            List<Publishers> publishers = new List<Publishers>()
            {
                new Publishers(){PublisherCountry = "iran", ID =0,Name = "fds"},
                new Publishers(){PublisherCountry = "turkey", ID =1,Name = "hgfsd"},
                new Publishers(){PublisherCountry = "usa", ID =2,Name = "jgfj"},
                new Publishers(){PublisherCountry = "germany", ID =3,Name = "jgfh"},
            };
            return publishers;
    }
        }
}
