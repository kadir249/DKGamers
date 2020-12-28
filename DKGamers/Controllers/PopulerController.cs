﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Models;

namespace DKGamers.Controllers
{
    public class PopulerController : Controller
    {
        private Context context = new Context();
        public IActionResult Index()
        {
            var oyunlar = context.Oyun.ToList();
            return View(new OyunListViewModel()
            {
                Oyunlar = oyunlar
            });
        }
        public IActionResult Detail(int id)
        {
            var oyun = context.Oyun.FirstOrDefault(i => i.OyunID == id);
            return View(oyun);
        }
    }
}