﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class Context :DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Conventions.Add(new KeyConvention());
            //modelBuilder.Conventions.Add(new DateTimeConvention());
           // modelBuilder.Configurations.Add(new DocumentConfiguration());
            //modelBuilder.Configurations.Add(new EmpruntConfiguration());
            //TPT Stratégie d'heritage
            //modelBuilder.Entity<Adherant>().ToTable("Adherant");
            //modelBuilder.Entity<Professeur>().ToTable("Professeur");
            //modelBuilder.Entity<Etudiant>().ToTable("Etudiant");
        }

    }
}
