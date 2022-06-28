using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMesajlar2Service : IGenericService<Mesajlar2>
    {
        List<Mesajlar2> HepsiniGetirYazarGelenMesaj(int id);
        List<Mesajlar2> GonderilenMesajlar(int id);
        
    }
}
