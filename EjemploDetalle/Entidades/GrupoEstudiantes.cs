using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entidades;

namespace EjemploDetalle.Entidades
{
   public  class GrupoEstudiantes
    {
        [Key]
        public int Id{ get; set; }
        public int EstudianteId{ get; set; }
        public int GrupoId { get; set; }

        public virtual List<Grupos> Grupos { get; set; }
        public virtual List<Estudiantes> Estudiantes { get; set; }


    }
}
