using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cukiernia.Models
{
    public class Pracownik
    {
        [Key]
        public int IdPracownik { get; set; }
        [MaxLength(50)]
        public string Imie { get; set; }
        [MaxLength(60)]
        public string Nazwisko { get; set; }
    }
}