using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
  public   class GrupoEstudiantes
    {
        [Key]
        public int GrupoEstudiantesId { get; set; }
        public int GrupoId { get; set; }
        public int EstudianteId { get; set; }

        
    }
}
