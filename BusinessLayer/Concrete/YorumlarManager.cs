using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class YorumlarManager : IYorumlarService
    {
        IYorumlarDal _yorumlarDal;

        public YorumlarManager(IYorumlarDal yorumlarDal)
        {
            _yorumlarDal = yorumlarDal;
        }
        public Yorumlar GetirID(int id)
        {
            throw new NotImplementedException();
        }
        public List<Yorumlar> HepsiniGetir(int id)
        {
            
            return _yorumlarDal.HepsiniGetir(x => x.BlogID == id);
        }
        public void YorumEkle(Yorumlar yorumlar)
        {
           _yorumlarDal.Ekle(yorumlar);
        }

        public void YorumGuncelle(Yorumlar yorumlar)
        {
            throw new NotImplementedException();
        }

        public void YorumSil(Yorumlar yorumlar)
        {
            throw new NotImplementedException();
        }
    }
}
