﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alisveris.Models
{
    public class Sepet
    {
        public Sepet()
        {
            this.Urun = new List<Urun>();
        }
    

        public int sepet_id { get; set; }
        public decimal toplam_odeme { get; set; }
        public int user_id { get; set; }
        public virtual ICollection<Urun> Urun{ get; set; }



    }
}
