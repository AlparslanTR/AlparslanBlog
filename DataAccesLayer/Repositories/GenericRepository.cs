using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Ekle(T entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public T GetirID(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Guncelle(T entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }

        public List<T> HepsiniGetir()
        {
            return c.Set<T>().ToList();
        }

        public List<T> HepsiniGetir(Expression<Func<T, bool>> filtre)
        {
            return c.Set<T>().Where(filtre).ToList();
        }

        public void Sil(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }
    }
}
