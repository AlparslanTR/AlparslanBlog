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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> BlogGetirYazaraGore(int id)
        {
           return _blogDal.HepsiniGetir(x=>x.YazarID==id).TakeLast(5).ToList();
        }

        public Blog GetirID(int id)
        {
            return _blogDal.GetirID(id);
        }
        public List<Blog>GetirIdBlog(int id)
        {
            return _blogDal.HepsiniGetir(x=>x.BlogID==id);
        }

        public List<Blog> HepsiniGetir()
        {
            return _blogDal.HepsiniGetir();
        }
        public List<Blog> Son3Blog()
        {
            return _blogDal.HepsiniGetir().TakeLast(3).ToList();
        }
        public List<Blog> kategoriadigetir()
        {

            return _blogDal.kategoriadıgetir();
        }

        public List<Blog> kategoriadigetir4()
        {

            return _blogDal.kategoriadıgetir().TakeLast(4).ToList();
        }
        public List<Blog>Son5Blog()
        {
            return _blogDal.HepsiniGetir(x=>x.YazarID==1).TakeLast(5).ToList();
        }
        public void TEkle(Blog t)
        {
            _blogDal.Ekle(t);
        }

        public void TSil(Blog t)
        {
            _blogDal.Sil(t);
        }

        public void TGuncelle(Blog t)
        {
            _blogDal.Guncelle(t);
        }
        public List<Blog> KategoriAdiGetirYazar(int id)
        {
            return _blogDal.kategoriadıgetirYazar(id);
        }
    }
}
