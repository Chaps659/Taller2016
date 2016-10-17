using ProyectoBetaDDD.Data.EntidadesConfig;
using ProyectoBetaDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBetaDDD.Data.Contexto
{
    public class ProyectoBetaContext : DbContext
    {
        public ProyectoBetaContext()
            : base("ConexionBD")
        {

        }


        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<HistorialAcademico> HistorialAcademico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AlumnoConfig());
            modelBuilder.Configurations.Add(new HistorialAcademicoConfig());

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("FechaNacimiento") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("FechaNacimiento").CurrentValue = DateTime.Now;

                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("FechaNacimiento").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}