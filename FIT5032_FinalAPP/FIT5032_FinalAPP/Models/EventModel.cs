using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_FinalAPP.Models
{
    public partial class EventModel : DbContext
    {
        public EventModel()
            : base("name=EventModel")
        {
        }

        public virtual DbSet<Events> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}
