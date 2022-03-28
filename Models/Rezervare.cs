using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicatieWeb.Models
{
    public class Rezervare
    {
        public int ID { get; set;  }
        public DateTime Data { get; set; }
        public ICollection<Client> Clienti { get; set; }
        public ICollection<Meniu> Meniuri { get; set; }
    }
}
