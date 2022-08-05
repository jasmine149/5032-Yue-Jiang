using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_FinalAPP.Models
{
    public partial class Imagemodlel : DbContext
    {
        public Imagemodlel()
            : base("name=Imagemodlel")
        {
        }

        public virtual DbSet<Images> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Images>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Images>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
