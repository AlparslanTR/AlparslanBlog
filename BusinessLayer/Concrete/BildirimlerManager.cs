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
    public class BildirimlerManager : IBildirimService
    {
        IBildirimDal bildirimDal;

        public BildirimlerManager(IBildirimDal bildirimDal)
        {
            this.bildirimDal = bildirimDal;
        }

        public Bildirimler GetirID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bildirimler> HepsiniGetir()
        {
            return bildirimDal.HepsiniGetir();
        }

        public void TEkle(Bildirimler t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Bildirimler t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Bildirimler t)
        {
            throw new NotImplementedException();
        }
    }
}
