using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_FinalAPP.Models
{
    public partial class FIT5032_Models : DbContext
    {
        public FIT5032_Models()
            : base("name=FIT5032_Models")
        {
        }

        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Units> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<FIT5032_FinalAPP.Models.MOCK_DATA> MOCK_DATA { get; set; }

        public System.Data.Entity.DbSet<FIT5032_FinalAPP.Models.Images> Images { get; set; }
    }
}
