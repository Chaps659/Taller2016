using ProyectoBetaDDD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProyectoBetaDDD.Data.EntidadesConfig
{
    public class HistorialAcademicoConfig : EntityTypeConfiguration<HistorialAcademico>
    {
        public HistorialAcademicoConfig()
        {
            HasKey(p => p.HistorialID);

            Property(p => p.Descripcion)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Materias)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Foto)
               .IsRequired()
               .HasMaxLength(300);

            HasRequired(p => p.Alumno)
                .WithMany()
                .HasForeignKey(p => p.AlumnoId);
        }
    }
}
