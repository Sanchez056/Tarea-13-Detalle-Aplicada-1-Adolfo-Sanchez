using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Entidades
{
   public class Estudiantes
    {
        

        [Key]
        public int EstudianteId { get; set; }
        public string Nombres{ get; set; }


       //public virtual ICollection<Grupos> Grupos { get; set; }
       //public virtual ICollection<GruposEstudiantes> grupos { get; set; }
       
       // public virtual ICollection<Grupos> Grupos { get; set; }
       public virtual List<Grupos> Grupos { get; set; }
        public Estudiantes()
        {
            this.Grupos = new List<Grupos>();
        }

       // [Browsable(false)]
        public Estudiantes(int estudianteId,string nombres)
        {
            this.EstudianteId = estudianteId;
            this.Nombres = nombres;
            this.Grupos = new List<Grupos>();

        }
        
        
    }
}
