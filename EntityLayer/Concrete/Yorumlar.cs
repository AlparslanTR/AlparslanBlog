using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorumlar
    {
        [Key]
        public int YorumID { get; set; }
        public string YorumAd { get; set; }
        public string YorumBasligi { get; set; }
        public string Yorum { get; set; }
        public DateTime YorumTarihi { get; set; }
        public bool YorumDurumu { get; set; }
        //
        public int BlogID { get; set; }
        public Blog blog { get; set; }
    }
}
