using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cukiernia.Models
{
    public class Zamowienie_WyrobCukierniczy
    {
        [Key, Column(Order=1)]
        public int IdWyrobuCukierniczego { get; set; }
        public WyrobCukierniczy WyrobCukierniczy { get; set; }

        [Key, Column(Order=2)]
        public int IdZamowienia { get; set; }
        public Zamowienie Zamowienie { get; set; }

        public int Ilosc { get; set; }

        [MaxLength(300)]
        public string Uwagi { get; set; }

    }
}