using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
  public   class GruposEstudiantes
    {
       // [Key]
        public int GrupoEstudiantesId { get; set; }
        public int GrupoId { get; set; }
        public int EstudianteId { get; set; }

        public virtual List<Estudiantes> Estudiante { get; set; }

       // public virtual ICollection<Estudiantes> Estudiantes { get; set; }
       // public virtual ICollection<Grupos> Grupos { get; set; }
    }
}
