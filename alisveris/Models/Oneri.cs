﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alisveris.Models
{
    public class Oneri
    {
        public int oneri_id { get; set; }
        public string oneri_icerik { get; set; }
        public DateTime oneri_tarih { get; set; }
        public int user_id { get; set; }
    }
}
