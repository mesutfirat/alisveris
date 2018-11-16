using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alisveris.Models
{
    public class Rol
    {
        public Rol() {
            this.User = new List<User>();
        }

        public int rol_id { get; set; }
        public string rol_adi { get; set; }
        public virtual ICollection<User> User{ get; set; }

    }
}
