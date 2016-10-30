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
    public partial class RegistrosGrupos : Form
    {
        public RegistrosGrupos()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Llenar(BLL.GruposBLL.Buscar(ut.StringToInt(GrupoIdtextBox.Text)));
        }
        private void Llenar(Grupos g)
        {
            GrupoIdtextBox.Text = g.grupoId.ToString();
            NombrestextBox.Text =g.Nombres;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Grupos grupos = new Grupos();
            LLenarClase(grupos);
            BLL.GruposBLL.Insertar(grupos);
            Limpiar();
            MessageBox.Show("Guardado Con Exito");
        }
        private void LLenarClase(Grupos grupos)
        {
            grupos.Nombres = NombrestextBox.Text;
        }
        private void Limpiar()
        {
            GrupoIdtextBox.Clear();
            NombrestextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            BLL.GruposBLL.Eliminar(ut.StringToInt(GrupoIdtextBox.Text));
            Limpiar();
            MessageBox.Show("Se Elimino Corretamente");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
