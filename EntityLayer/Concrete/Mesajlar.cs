using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesajlar
    {
        [Key]
        public int MesajID { get; set; }
        public string GonderenMail { get; set; }
        public string AlıcıMail { get; set; }
        public string Konu { get; set; }
        public string Mesajın { get; set; }
        public DateTime MesajTarih { get; set; }
        public bool MesajDurumu { get; set; }

    }
}
