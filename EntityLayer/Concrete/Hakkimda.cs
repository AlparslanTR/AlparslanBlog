using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimda
    {
        [Key]
        public int HakkimdaID { get; set; }
        public string HakkimdaDetay { get; set; }
        public string HakkimdaDetay2 { get; set; }
        public string HakkimdaResim { get; set; }
        public string HakkimdaResim2 { get; set; }
        public string HakkimdaLokasyon { get; set; }
        public bool HakkimdaDurum { get; set; }
    }
}
