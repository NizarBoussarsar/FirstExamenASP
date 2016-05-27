using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FirstExamenASP.Domain.Entities;

namespace FirstExamenASP.Data
{
    public partial class FirstExamenASPDB : DbContext
    {
        public FirstExamenASPDB()
            : base("name=FirstExamenASP")
        {
        }

        public virtual DbSet<Domicile> Domicile { get; set; }
        public virtual DbSet<Entrepreneur> Entrepreneur { get; set; }
        public virtual DbSet<Residence> Residence { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appartement>()
                .Property(e => e.Immeuble)
                .IsUnicode(false);

            modelBuilder.Entity<Entrepreneur>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Entrepreneur>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Entrepreneur>()
                .Property(e => e.Adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Entrepreneur>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Entrepreneur>()
                .HasMany(e => e.Residence)
                .WithOptional(e => e.Entrepreneur)
                .HasForeignKey(e => e.IdEntrepreneur);

            modelBuilder.Entity<Residence>()
                .HasMany(e => e.Domicile)
                .WithOptional(e => e.Residence)
                .HasForeignKey(e => e.IdResidence);

            //****************************************//

            //1 => Villa, 0 => Appartement
            //Seule une villa posséde des champs APiscine et AGarage
            //Seule un appartement posséde le champs Immeuble
            modelBuilder.Entity<Domicile>().Map<Villa>(d =>
            {
                d.Requires("IsVilla").HasValue(1);
            });
            modelBuilder.Entity<Domicile>().Map<Appartement>(d =>
            {
                d.Requires("IsVilla").HasValue(0);
            });

        }
    }
}
