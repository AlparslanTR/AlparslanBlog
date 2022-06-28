using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entity_Framework
{
    public class EFMesajlar2Repository : GenericRepository<Mesajlar2>, IMesaj2Dal
    {
        public List<Mesajlar2> gonderenMesaj(int id)
        {
            using (var c = new Context())
            {
                return c.mesajlarss2.Include(x => x.yazaralan).Where(x => x.GonderenMailID == id).ToList();
            }
        }

        public List<Mesajlar2> MesajYazanAdıgetirYazar(int id)
        {
            using (var c = new Context())
            {
                return c.mesajlarss2.Include(x => x.yazargonderen).Where(x => x.AlıcıMailID == id).ToList();
            }
        }
    }
}
