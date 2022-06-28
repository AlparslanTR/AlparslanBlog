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
    public class Mesajlar2Manager : IMesajlar2Service
    {
        IMesaj2Dal Mesaj2Dal;

        public Mesajlar2Manager(IMesaj2Dal mesaj2Dal)
        {
            Mesaj2Dal = mesaj2Dal;
        }

        public Mesajlar2 GetirID(int id)
        {
            return Mesaj2Dal.GetirID(id);
        }

        public List<Mesajlar2> GonderilenMesajlar(int id)
        {
            return Mesaj2Dal.gonderenMesaj(id);
        }

        public List<Mesajlar2> HepsiniGetir()
        {
            return Mesaj2Dal.HepsiniGetir();
        }

        public List<Mesajlar2> HepsiniGetirYazarGelenMesaj(int id)
        {
            return Mesaj2Dal.MesajYazanAdıgetirYazar(id);
        }

        public void TEkle(Mesajlar2 t)
        {
            Mesaj2Dal.Ekle(t);
        }

        public void TGuncelle(Mesajlar2 t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Mesajlar2 t)
        {
            throw new NotImplementedException();
        }
    }
}
