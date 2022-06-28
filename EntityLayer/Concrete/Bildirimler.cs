using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bildirimler
    {
        [Key]
        public int BildirimID { get; set; }
        public string BildirimTuru { get; set; }
        public string BildirimTuruSembol { get; set; }
        public string BildirimDetaylari { get; set; }
        public DateTime BildirimTarihi { get; set; }
        public bool BildirimDurumu { get; set; }
        public string BildirimRengi { get; set; }
    }
}
