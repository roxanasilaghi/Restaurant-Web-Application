using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicatieWeb.Models
{
    public class Client
    { 
        public int ID { get; set;  }
        public string Nume { get; set;  }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int RezervareID { get; set; }
        public Rezervare Rezervare { get; set; }

    }
}
