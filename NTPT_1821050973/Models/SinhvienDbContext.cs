using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTPT_1821050973.Models
{
    public partial class SinhvienDbContext : DbContext
    {
        public SinhvienDbContext()
            : base("name=SinhvienDbContext")
        {
        }
        public virtual DbSet<Sinhvien> Sinhviens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
