using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal kategoryDal;

        public KategoriManager(IKategoriDal kategoryDal)
        {
            this.kategoryDal = kategoryDal;
        }

        public Kategori GetirID(int id)
        {
            return kategoryDal.GetirID(id);
        }

        public List<Kategori> HepsiniGetir()
        {
            return kategoryDal.HepsiniGetir();
        }

        public void TEkle(Kategori t)
        {
            kategoryDal.Ekle(t);
        }

        public void TGuncelle(Kategori t)
        {
            kategoryDal.Guncelle(t);
        }

        public void TSil(Kategori t)
        {
            kategoryDal.Sil(t);
        }
    }
}
