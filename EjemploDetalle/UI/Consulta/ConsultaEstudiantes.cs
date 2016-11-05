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

namespace EjemploDetalle.Consulta
{
    public partial class ConsultaEstudiantes : Form
    {
        Grupos grupo = new Grupos();
        List<Estudiantes> lista = new List<Estudiantes>();

        //public List<GruposEstudiantes> lista = new List<GruposEstudiantes>();
        public ConsultaEstudiantes()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {
                lista = EstudiantesBLL.GetLista(ut.StringToInt(FiltrotextBox.Text));

            }
            else
            {
                lista = EstudiantesBLL.GetLista();
            }
            ConsultaEstudiantesdataGridView.DataSource = lista;

            //cargarEstudiantesGrupo(grupo.Estudiantes);
        }

        private void ConsultaEstudiantesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
