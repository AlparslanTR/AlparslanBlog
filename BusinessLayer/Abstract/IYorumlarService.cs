using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYorumlarService
    {
        void YorumEkle(Yorumlar yorumlar);
        void YorumSil(Yorumlar yorumlar);
        void YorumGuncelle(Yorumlar yorumlar);
        List<Yorumlar> HepsiniGetir(int id);
        Yorumlar GetirID(int id);
    }
}
