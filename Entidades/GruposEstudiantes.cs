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

        //public virtual List<Estudiantes> Estudiantes { get; set; }

    }
}
