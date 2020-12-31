using DKGamers.Identity;
using DKGamers.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{
    public class FavoriController : Controller
    {
        private UserManager<Kullanici> kullaniciYoneticisi;
        private Favori favori = new Favori();
        private Context context = new Context();
        public FavoriController(UserManager<Kullanici> _kullaniciYoneticisi)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
        }
        public IActionResult Index()
        {           
            favori.KullaniciID = kullaniciYoneticisi.GetUserId(User);
            return View();
        }

        [HttpPost]
        public IActionResult FavoriyeEkle(int id)
        {
            favori.KullaniciID = kullaniciYoneticisi.GetUserId(User);
            favori.OyunID = id;
            
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult FavoridenCikar(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
