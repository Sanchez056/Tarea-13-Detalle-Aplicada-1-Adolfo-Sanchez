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

namespace EjemploDetalle.Consulta
{
    public partial class ConsultaEstudiantes : Form
    {
        Grupos grupo = new Grupos();
        //public List<GruposEstudiantes> lista = new List<GruposEstudiantes>();
        public ConsultaEstudiantes()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var grupos= BLL.EstudiantesBLL.Buscar(ut.StringToInt(FiltrotextBox.Text));
           
            //cargarEstudiantesGrupo(grupo.Estudiantes);
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "ClienteId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
          // ConsultaEstudiantesdataGridView.DataSource = BLL.EstudiantesBLL.GetLista();
        }
       

        private void cargarEstudiantesGrupo(List<Estudiantes> lista)
        {
            var estudiantes = new List<Estudiantes>();
            foreach (Estudiantes est in lista)
            {
               // estudiantes.Add(BLL.EstudiantesBLL.Buscar(est.EstudianteId));
            }
           ConsultaEstudiantesdataGridView.DataSource = null;
           ConsultaEstudiantesdataGridView.DataSource = estudiantes;
        }
    }
}
