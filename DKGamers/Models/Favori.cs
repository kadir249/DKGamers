﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class Favori
    {
        public string KullaniciID { get; set; }
        public int OyunID { get; set; }
        public List<Oyun> Oyunlar { get; set; }
    }
}
