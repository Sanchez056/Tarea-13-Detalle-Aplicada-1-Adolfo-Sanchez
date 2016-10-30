﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class EjemploDetalleDb : DbContext
    {
        public EjemploDetalleDb() : base("name=ConStr")
        {

        }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }
        //public virtual DbSet<GruposEstudiantes> GrupoEstudiante { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiantes)
                .WithMany(e => e.Grupos)
                .Map(ge =>
                {
                    ge.MapLeftKey("EstudianteId");
                    ge.MapRightKey("GrupoId");
                    ge.ToTable("GrupoEstudiantes");
                });
        }


    }
}