

using System;
using INJURY.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Reflection.Metadata.BlobBuilder;


// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INJURY.dataAcess.Context
{
    public partial class SQLFundamentalsContext : DbContext
    {

        public SQLFundamentalsContext()
        {

        }

        public SQLFundamentalsContext(DbContextOptions<SQLFundamentalsContext> options)
        : base(options)
        {
        }

        public virtual DbSet<InjuryModels> InjuryModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InjuryModels>(entity =>
            {
                entity.HasKey(e => e.InjuryID);

                entity.Property(e => e.InjuryID);

                entity.Property(e => e.LastName);

                entity.Property(e => e.FirstName);

                entity.Property(e => e.Address);

                entity.Property(e => e.City);

                entity.Property(e => e.Injury);


            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

