using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogBasligi { get; set; }
        public string BlogIcerik { get; set; }
        public string BlogUfakResim { get; set; }
        public string BlogResim { get; set; }
        public DateTime BlogOlusturmaTarihi { get; set; }
        public bool BlogDurum { get; set; }
        public string BlogOzet { get; set; }
        //
        public int KategoriID { get; set; }
        public Kategori kategori { get; set; }
        public List<Yorumlar> yorumlars { get; set; }
        public int YazarID { get; set; }
        public Yazar yazar { get; set; }
    }
}
