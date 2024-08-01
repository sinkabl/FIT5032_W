using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_Weak05C.Models
{
    public partial class WeekCModel1 : DbContext
    {
        public WeekCModel1()
            : base("name=WeekCModel1")
        {
        }

        public virtual DbSet<MOCK_DATA> MOCK_DATA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.ip_address)
                .IsUnicode(false);
        }
    }
}
