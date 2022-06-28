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
    public class EFProjelerRepository:GenericRepository<Projeler>,IProjeDal
    {
        List<Projeler> IProjeDal.kategoriadıgetirYazar(int id)
        {
            using (var c = new Context())
            {
                return c.projelers.Include(x => x.yazar).Where(x => x.YazarID == id).ToList();
            }
        }
    }
}
