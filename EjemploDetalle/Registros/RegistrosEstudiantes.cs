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
            Llenar( BLL.EstudiantesBLL.Buscar(ut.StringToInt(EstudiantesIdtextBox.Text)));
        }
       private void Llenar( Estudiantes estudiantes)
        {
            EstudiantesIdtextBox.Text = estudiantes.EstudianteId.ToString();
            NombrestextBox.Text = estudiantes.Nombres;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();
            LLenarClase(estudiantes);
            BLL.EstudiantesBLL.Insertar(estudiantes);
            Limpiar();
            MessageBox.Show("Guardado Con Exito");
            
            

        }
         private void LLenarClase(Estudiantes estudiantes)
        {
            estudiantes.Nombres = NombrestextBox.Text;
        }
        private void Limpiar()
        {
            EstudiantesIdtextBox.Clear();
            NombrestextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            BLL.EstudiantesBLL.Eliminar(ut.StringToInt(EstudiantesIdtextBox.Text));
            Limpiar();
            MessageBox.Show("Se Elimino Corretamente");
        }
    }
}
