using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-38ER4CK\\SQLEXPRESS;database=AlparslanBlog2; integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesajlar2>()
                .HasOne(x=>x.yazargonderen)
                .WithMany(x=>x.yazargonderici)
                .HasForeignKey(x=>x.GonderenMailID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Mesajlar2>()
                .HasOne(x => x.yazaralan)
                .WithMany(x => x.yazaralici)
                .HasForeignKey(x => x.AlıcıMailID);
        }

        public DbSet<Blog> blogss { get; set; }
        public DbSet<Hakkimda> hakkimdass { get; set; }
        public DbSet<Iletisim> ıletisimss { get; set; }
        public DbSet<Kategori> kategoriss { get; set; }
        public DbSet<Yazar> yazarss { get; set; }
        public DbSet<Yorumlar> yorumlarss { get; set; }
        public DbSet<Aboneler> abonelerss { get; set; }
        public DbSet<Bildirimler> bildirimlerss { get; set; }
        public DbSet<Mesajlar> mesajlarss { get; set; }
        public DbSet<Mesajlar2> mesajlarss2 { get; set; }
        public DbSet<Projeler> projelers { get; set; }
    }
}
