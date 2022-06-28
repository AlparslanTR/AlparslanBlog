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
    public class ProjelerManager : IProjeService
    {
        IProjeDal _projeDal;

        public ProjelerManager(IProjeDal projeDal)
        {
            _projeDal = projeDal;
        }

        public Projeler GetirID(int id)
        {
            return _projeDal.GetirID(id);
        }
        public List<Projeler> GetirIdProje(int id)
        {
            return _projeDal.HepsiniGetir(x => x.ProjeID == id);
        }
        public List<Projeler> HepsiniGetir()
        {
            return _projeDal.HepsiniGetir();
        }
        public List<Projeler> KategoriAdiGetirYazar(int id)
        {
            return _projeDal.kategoriadıgetirYazar(id);
        }
        public List<Projeler> GetirIki()
        {
            return _projeDal.HepsiniGetir(x=>x.YazarID==1).TakeLast(2).ToList();
        }
        public void TEkle(Projeler t)
        {
            _projeDal.Ekle(t);
        }

        public void TGuncelle(Projeler t)
        {
            _projeDal.Guncelle(t);
        }

        public void TSil(Projeler t)
        {
            _projeDal.Sil(t);
        }
    }
}
