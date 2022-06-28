using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Ekle (T entity);
        void Sil (T entity);
        void Guncelle (T entity);
        List<T> HepsiniGetir ();
        T GetirID(int id);
        List<T> HepsiniGetir(Expression<Func<T, bool>> filtre);
    }
}
