using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBetaDDD.Dominio.Entidades
{
    public class HistorialAcademico
    {
        public int HistorialID { get; set; }

        public string Descripcion { get; set; }

        public string Materias { get; set; }

        public string Foto { get; set; }

        public int AlumnoId { get; set; }

        public virtual Alumno Alumno { get; set; }

                
    }
}
