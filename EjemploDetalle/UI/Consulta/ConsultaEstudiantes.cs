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
        Estudiantes estudiantes = new Estudiantes();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //var grupos = BLL.GruposBLL.Buscar((int)ConsultaEstudiantesdataGridView.CurrentRow.Cells[0].Value);
           
              var grupos = BLL.GruposBLL.Buscar((int)ConsultaEstudiantesdataGridView.CurrentRow.Cells[0].Value);
            ConsultaEstudiantesdataGridView.DataSource = estudiantes.Grupos;

            //cargarEstudiantesGrupo(grupo.Estudiantes);
        }

        private void ConsultaEstudiantesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
