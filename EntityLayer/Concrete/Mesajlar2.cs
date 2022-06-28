using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesajlar2
    {
        [Key]
        public int MesajID { get; set; }
        public int? GonderenMailID { get; set; }
        public int? AlıcıMailID { get; set; }
        public string Konu { get; set; }
        public string Mesajın { get; set; }
        public DateTime MesajTarih { get; set; }
        public bool MesajDurumu { get; set; }
        //
        public Yazar yazargonderen { get; set; }
        public Yazar yazaralan { get; set; }
    }
}
