using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class GruposEstudiantesBLL
    {
        public static void Insertar(GrupoEstudiantes gp)
        {
            //bool retorno = false;
            try
            {
                var db = new EjemploDetalleDb();

                db.GrupoEstudiantes.Add(gp);
                db.SaveChanges();
                db.Dispose();

                //retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // return retorno;
        }


        public static List<GrupoEstudiantes> GetLis(int grupoId)
        {
            var lista = new List<GrupoEstudiantes>();
            using (var db= new EjemploDetalleDb())
            {
                try
                {
                    lista = db.GrupoEstudiantes.Where(ge => ge.GrupoId == grupoId).ToList();
                }
                catch (Exception)
                {
                }
            }
            return lista;
        }

        public static List<GrupoEstudiantes> GetLista()
        {
            List<GrupoEstudiantes> lista = new List<GrupoEstudiantes>();
            var db = new EjemploDetalleDb();

            lista = db.GrupoEstudiantes.ToList();
            return lista;
        }


    }
     
    }

