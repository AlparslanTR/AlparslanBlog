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
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> kategoriadıgetir()
        {
            using(var c = new Context())
            {
                return c.blogss.Include(x=>x.kategori).ToList();
            }
            
        }

        public List<Blog> kategoriadıgetirYazar(int id)
        {
            using (var c = new Context())
            {
                return c.blogss.Include(x => x.kategori).Where(x=>x.YazarID==id).ToList();
            }
        }
    }
}
