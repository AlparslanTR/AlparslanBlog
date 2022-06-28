using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IMesaj2Dal:IGenericDal<Mesajlar2>
    {
        List<Mesajlar2> MesajYazanAdıgetirYazar(int id);
        List<Mesajlar2> gonderenMesaj(int id);
    }
}
