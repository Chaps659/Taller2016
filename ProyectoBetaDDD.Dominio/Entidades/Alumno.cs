using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBetaDDD.Dominio.Entidades
{
    public class Alumno
    {
        public int AlumnoID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public bool Activo { get; set; }

        public IEnumerable<HistorialAcademico> HistoriaAcademico { get; set; }

        public bool AlumnoEspecial(Alumno alumno)
        {
            return alumno.Activo && DateTime.Now.Year - alumno.FechaNacimiento.Year >= 5;
        }
    }
}
