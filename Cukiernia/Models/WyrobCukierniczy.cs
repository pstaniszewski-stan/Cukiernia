using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cukiernia.Models
{
    public class WyrobCukierniczy
    {
        [Key]
        public int IdWyrobuCukierniczego { get; set; }
        [MaxLength(400)]
        public string Nazwa { get; set; }
        public float CenaZaSzt{ get; set; }
        [MaxLength(40)]
        public string Typ { get; set; }

    }
}