using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TEkle(T t);
        void TSil(T t);
        void TGuncelle(T t);
        List<T> HepsiniGetir();
        T GetirID(int id);
    }
}
