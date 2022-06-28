using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarMail { get; set; }
        public string YazarSifre { get; set; }
        public string YazarHakkinda { get; set; }
        public string YazarResim { get; set; }
        public bool YazarDurumu { get; set; }
        public List<Blog> blogs { get; set; }
        public List<Projeler>projelers { get; set; }

        //
        public virtual ICollection<Mesajlar2> yazargonderici { get; set; }
        public virtual ICollection<Mesajlar2> yazaralici { get; set; }
    }
}
