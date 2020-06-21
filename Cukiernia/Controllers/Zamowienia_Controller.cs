using Cukiernia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cukiernia.Controllers
{
    [ApiController]
    [System.Web.Mvc.Route("api/")]
    public class Zamowienia_Controller : Controller
    {

        private readonly ZamowienieDBContext _zamowienieContext;

        public Zamowienia_Controller(ZamowienieDBContext zamowienieContext)
        {
            this._zamowienieContext = zamowienieContext;
        }

        [System.Web.Http.HttpGet()]
        public IActionResult GetZamowienie()
        {
            var zamowienia = this._zamowienieContext.Zamowienia;

            return Ok(zamowienia);
        }

        private IActionResult Ok(DbSet<Zamowienie> zamowienia)
        {
            throw new NotImplementedException();
        }

        [System.Web.Mvc.HttpPost()]
        public IActionResult AddZamowienie(Zamowienie zamowienie)
        {
            Zamowienie noweZamowienie = new Zamowienie
            {
                IdZamowienia = Zamowienie.IdZamowienia,
                DataPrzyjecia = Zamowienie.DataPrzyjecia,
                Uwagi = Zamowienie.Uwagi,
                Klient = Zamowienie.Klient,
                Pracownik = Zamowienie.Pracownik,
            };

            this._zamowienieContext.Add(noweZamowienie);
            this._zamowienieContext.SaveChanges();

            return Ok();
        }

        private IActionResult Ok()
        {
            throw new NotImplementedException();
        }
    }
}
