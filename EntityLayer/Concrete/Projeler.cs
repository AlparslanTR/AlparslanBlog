using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Projeler
    {
        [Key]
        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }
        public DateTime ProjeTarihi { get; set; }
        public string ProjeAciklama { get; set; }
        public string ProjeBüyükResim { get; set; }
        public string ProjeKücükResim { get; set; }
        public string ProjeOzet { get; set; }
        //
        public int YazarID { get; set; }
        public Yazar yazar { get; set; }
    }
}
