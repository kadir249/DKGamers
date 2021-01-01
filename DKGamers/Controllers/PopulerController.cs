using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Models;
using Microsoft.EntityFrameworkCore;
using DKGamers.Data;

namespace DKGamers.Controllers
{
    public class PopulerController : Controller
    {
        private Context context = new Context();
        public IActionResult Index()
        {
            var oyunlar = context.Oyun.ToList();
            oyunlar = oyunlar.OrderByDescending(x => x.GoruntulenmeSayisi).ToList();
            oyunlar = oyunlar.Take(10).ToList();
            return View(new OyunListViewModel()
            {
                Oyunlar = oyunlar
            });
        }
        public IActionResult Detail(int id)
        {
            Oyun oyun = context.Oyun.Include(i => i.OyunKategorileri).ThenInclude(i => i.Kategori).FirstOrDefault(i => i.OyunID == id);
            return View(oyun);
        }
    }
}