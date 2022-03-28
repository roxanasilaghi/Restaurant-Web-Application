using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicatieWeb.Models
{
    public class Meniu
    {
        public int ID { get; set; }
        public string Tip { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        public int RezervareID { get; set; }
        public Rezervare Rezervare { get; set; }
    }
}

