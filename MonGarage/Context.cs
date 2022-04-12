using MonGarage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MonGarage
{
    public class Context : DbContext
    {
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Fiche> Fiches { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Entity<Fiche>().HasRequired(fiche => fiche.Voiture);
            dbModelBuilder.Entity<Fiche>().HasRequired(fiche => fiche.Client);
            dbModelBuilder.Entity<Voiture>().HasRequired(voiture => voiture.Marque);
        }
    }
}