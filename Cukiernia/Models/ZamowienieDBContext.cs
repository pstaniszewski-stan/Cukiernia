using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace Cukiernia.Models
{
    public class ZamowienieDBContext : DbContext
    {
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<WyrobCukierniczy> WyrobyCukiernicze { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<Zamowienie_WyrobCukierniczy> Zamowienia_WyrobyCukiernicze { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}