using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alisveris.Models
{
    public class Yorum
    {
        public int yorum_id { get; set; }
        public string yorum_icerik { get; set; }
        public DateTime yorum_tarih { get; set; }
        public int urun_id { get; set; }
        public int user_id { get; set; }
    }
}
