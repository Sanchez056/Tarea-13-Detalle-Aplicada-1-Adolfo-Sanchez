using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace EjemploDetalle.Registros
{
    public partial class RegistrosEstudiantes : Form
    {
        public RegistrosEstudiantes()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Estudiantes que desea buscar") && ValidarBuscar())
                Llenar(EstudiantesBLL.Buscar(ut.StringToInt(EstudiantesIdtextBox.Text)));


        }

       private void Llenar( Estudiantes estudiantes)
        {
            EstudiantesIdtextBox.Text = estudiantes.EstudianteId.ToString();
            NombrestextBox.Text = estudiantes.Nombres;
            
       
        }
        Estudiantes estudiante = new Estudiantes();
       

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
            BuscarerrorProvider.Clear();
            LLenarClase(estudiante);
            if (ValidarTextbox() && ValidarExiste(NombrestextBox.Text))
            {
                EstudiantesBLL.Insertar(estudiante);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }


        }
         private void LLenarClase(Estudiantes estudiantes)
        {
            estudiantes.Nombres = NombrestextBox.Text;
        }
        private void Limpiar()
        {
            EstudiantesIdtextBox.Clear();
            NombrestextBox.Clear();
            limpiarErroresProvider();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
             
          

            if (validarId("Favor digitar el id del Estudiante que desea eliminar") && ValidarBuscar())
            {
                EstudiantesBLL.Eliminar(ut.StringToInt(EstudiantesIdtextBox.Text));
                Limpiar();
                MessageBox.Show("Se Elimino Corretamente");

            }


        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombrestextBox.Text) 
                
                )
            { 
                NombreserrorProvider.SetError(NombrestextBox, "Favor Ingresar el Nombre de Estudiantes");
                

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombrestextBox.Text))
            {
               NombreserrorProvider.Clear();
               NombreserrorProvider.SetError(NombrestextBox, "Favor ingresar el Nombre del Estudiantes");
                return false;
            }
            return true;
        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(EstudiantesIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarBuscar()
        {
            if (EstudiantesBLL.Buscar(ut.StringToInt(EstudiantesIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }

        private bool ValidarExiste(string aux)
        {
            if (EstudiantesBLL.GetListaNombres(aux).Count() > 0)
            {
                MessageBox.Show("Este Nombre  ya existe, favor intentar con otra Nombre ...");
                return false;
            }
            return true;
        }
        //-----
        private void limpiarErroresProvider()
        {
            NombreserrorProvider.Clear();
            

        }
        //-----
    }
}
