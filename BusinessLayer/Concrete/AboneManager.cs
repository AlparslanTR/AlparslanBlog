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
    public class AboneManager : IAboneService
    {
        IAboneDal _aboneDal;

        public AboneManager(IAboneDal aboneDal)
        {
            _aboneDal = aboneDal;
        }

        public void AboneEkle(Aboneler aboneler)
        {
            _aboneDal.Ekle(aboneler);
        }
    }
}
