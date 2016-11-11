using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Windows.Forms;

namespace BLL
{
   public  class EstudiantesBLL
    {
        public static bool  Insertar(Estudiantes est)
        {
           bool retorno = false;
            try
            {
                var db = new EjemploDetalleDb();

                db.Estudiantes.Add(est);
                db.SaveChanges();
                db.Dispose();

                retorno = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return retorno;
        }
        public static Estudiantes Buscar(int id)
        {
            Estudiantes estudiante = new Estudiantes();
            using (var db = new EjemploDetalleDb())
            {
                
                try
                {
                    estudiante = db.Estudiantes.Find(id);
                    estudiante.Grupos.Count();
                }
                catch (Exception e)
                {
                    throw e;
                }

                return estudiante;
            }

        }



        public static void Eliminar(int id)
        {
            var db = new EjemploDetalleDb();
            Estudiantes Es= db.Estudiantes.Find(id);

            db.Estudiantes.Remove(Es);
            db.SaveChanges();
        }


        public static List<Estudiantes> GetLista()
        {
            var lista = new List<Estudiantes>();

            var db = new EjemploDetalleDb();

            lista = db.Estudiantes.ToList();

            return lista;
        }
        public static List<Estudiantes> GetLista(int id)
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            EjemploDetalleDb db = new EjemploDetalleDb();

            lista = db.Estudiantes.Where(u => u.EstudianteId == id).ToList();
            return lista;
        }
        public static List<Estudiantes> GetListaNombres(string aux)
        {
            List<Estudiantes> lista = new List<Estudiantes>();

            var db = new EjemploDetalleDb();

            lista = db.Estudiantes.Where(p => p.Nombres == aux).ToList();

            return lista;

        }

    }
}
