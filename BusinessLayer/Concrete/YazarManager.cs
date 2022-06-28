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
    public class YazarManager : IYazarService
    {
        IYazarDal _yazarDal;

        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }

        public Yazar GetirID(int id)
        {
          return  _yazarDal.GetirID(id);
        }

        public List<Yazar> HepsiniGetir()
        {
            return _yazarDal.HepsiniGetir();
        }

        public void TEkle(Yazar t)
        {
            _yazarDal.Ekle(t);
        }
        public void TGuncelle(Yazar t)
        {
            _yazarDal.Guncelle(t);
        }

        public void TSil(Yazar t)
        {
            throw new NotImplementedException();
        }

        public List<Yazar> YazarGetirID(int id)
        {
            return _yazarDal.HepsiniGetir(x => x.YazarID == id);
        }

       
    }
}
