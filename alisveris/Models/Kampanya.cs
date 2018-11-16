using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alisveris.Models
{
    public class Kampanya
    {
        public int kampanya_id { get; set; }
        public decimal kampanya_fiyat { get; set; }
        public DateTime kampanya_baslangic { get; set; }
        public DateTime kampanya_bitis { get; set; }
        public int urun_id { get; set; }

    }
}
