using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public string Nombres { get; set; }

        public virtual List<Estudiantes> Estudiantes { get; set; }

        public Grupos()
        {
            this.Estudiantes = new List<Estudiantes>();
        }



       /* public Grupos(int grupoId, string nombreGrupo)
        {
            this.GrupoId = grupoId;
            this.Nombres = nombreGrupo;
            this.Estudiantes = new List<Estudiantes>();
        }*/


    }
}


