using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Data.Entity;

namespace BLL
{
   public  class GruposBLL
    {
        public static bool Insertar(Grupos gp)
        {
            bool retorno = false;
            try
            {
                var db = new EjemploDetalleDb();

                db.Grupos.Add(gp);
                var gr = db.Grupos.Add(gp);
                foreach(var est in gp.Estudiantes)
                {
                    db.Entry(est).State = EntityState.Unchanged;
                }
                db.SaveChanges();
                //db.Dispose();

                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }

             return retorno;
        }
        public static Grupos Buscar(int id)
        {
            Grupos grupos = new Grupos();
            var db = new EjemploDetalleDb();
            grupos = db.Grupos.Find(id);
            return grupos;

        }



        public static void Eliminar(int id)
        {
            var db = new EjemploDetalleDb();
            Grupos g = db.Grupos.Find(id);

            db.Grupos.Remove(g);
            db.SaveChanges();
        }

        public static List<Grupos> GetLista()
        {
            var lista = new List<Grupos>();

            var db = new EjemploDetalleDb();

            lista = db.Grupos.ToList();

            return lista;
        }
        public static List<Grupos> GetListaGrupos(int id)
        {
            List<Grupos> lista = new List<Grupos>();

            var db = new EjemploDetalleDb();

            lista = db.Grupos.Where(p => p.GrupoId == id && p.Estudiantes.Count > 0).ToList();

            return lista;

        }

        public static List<Grupos> GetListaNombres(string aux)
        {
            List<Grupos> lista = new List<Grupos>();

            var db = new EjemploDetalleDb();

            lista = db.Grupos.Where(p => p.Nombres == aux).ToList();

            return lista;

        }

    }
}
