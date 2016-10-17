using ProyectoBetaDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBetaDDD.Data.EntidadesConfig
{
    public class AlumnoConfig : EntityTypeConfiguration<Alumno>
    {
        public AlumnoConfig()
        {
            HasKey(c => c.AlumnoID);

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Apellido)
                .IsRequired()
                .HasMaxLength(150);

            

        }

    }
}
