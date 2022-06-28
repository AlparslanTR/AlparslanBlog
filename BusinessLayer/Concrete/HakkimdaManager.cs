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
    public class HakkimdaManager : IHakkimdaService
    {
        IHakkimdaDal _hakkimdadal;

        public HakkimdaManager(IHakkimdaDal hakkimdadal)
        {
            _hakkimdadal = hakkimdadal;
        }

        public Hakkimda GetirID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hakkimda> HepsiniGetir()
        {
            return _hakkimdadal.HepsiniGetir();
        }

        public void TEkle(Hakkimda t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Hakkimda t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Hakkimda t)
        {
            throw new NotImplementedException();
        }
    }
}
