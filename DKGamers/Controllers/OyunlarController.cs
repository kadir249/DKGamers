using DKGamers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Controllers
{
    public class OyunlarController : Controller
    {
        private Context context = new Context();
        public IActionResult Index()
        {
            var oyunlar = context.Oyun.OrderBy(o => o.OyunAdi).ToList();

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
