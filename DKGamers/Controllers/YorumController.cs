using DKGamers.Identity;
using DKGamers.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{

    public class YorumController : Controller
    {
        private Context context = new Context();
        private UserManager<Kullanici> kullaniciYoneticisi;
        public YorumController(UserManager<Kullanici> _kullaniciYoneticisi)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
        }
        public IActionResult Index()
        {
            var user = kullaniciYoneticisi.FindByNameAsync(User.Identity.Name).Result;
            var yorumlar = context.Yorum.Where(i => i.KullaniciAdi == user.UserName).ToList();
            return View(yorumlar);
        }
    }
}
