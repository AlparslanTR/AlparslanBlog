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
    public class MesajlarManager : IMesajService
    {
        IMesajDal MesajDal;

        public MesajlarManager(IMesajDal mesajDal)
        {
            MesajDal = mesajDal;
        }

        public Mesajlar GetirID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mesajlar> HepsiniGetir()
        {
            return MesajDal.HepsiniGetir();
        }

        public List<Mesajlar> HepsiniGetirYazarGelenMesaj(string p)
        {
            return MesajDal.HepsiniGetir(x=>x.AlıcıMail==p);
        }

        public void TEkle(Mesajlar t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Mesajlar t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Mesajlar t)
        {
            throw new NotImplementedException();
        }
    }
}
