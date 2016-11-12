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

        public ConsultaEstudiantes()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();
        Estudiantes estudiantes = new Estudiantes();
       // private object estu;

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LlenarId(EstudiantesBLL.Buscar(ut.StringToInt(FiltrotextBox.Text)));
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "EstudianteId");
            FiltrarcomboBox.Items.Insert(1, "Nombres");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
        }
        private void LlenarId(Estudiantes estu)
        {

            var est = EstudiantesBLL.Buscar(ut.StringToInt(FiltrotextBox.Text));
            FiltrotextBox.Text = estu.EstudianteId.ToString();
            NombreEstudiantetextBox.Text = estu.Nombres;
            ConsultaEstudiantesdataGridView.DataSource = null;
            ConsultaEstudiantesdataGridView.DataSource = estu.Grupos;


        }
       








        private void ConsultaEstudiantesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaEstudiantes_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        { 
            ReporEstudiantes viewer = new ReporEstudiantes();
            LlenarId(EstudiantesBLL.Buscar(ut.StringToInt(FiltrotextBox.Text)));
            var est = EstudiantesBLL.Buscar(ut.StringToInt(FiltrotextBox.Text));
            ConsultaEstudiantesdataGridView.DataSource = null;

            viewer.EstudiantesreportViewer.Reset();
            viewer.EstudiantesreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.EstudiantesreportViewer.LocalReport.ReportPath = @"D:\Tarea de Aplicada 1\Tarea#12 EjemploDetalle Adolfo Sanchez\EjemploDetalle\EjemploDetalle\Reportes\ListadosDeEstudiantes.rdlc";


            viewer.EstudiantesreportViewer.LocalReport.DataSources.Clear();

            //var ests = EstudiantesBLL.Buscar(ut.StringToInt(FiltrotextBox.Text));

            viewer.EstudiantesreportViewer.LocalReport.DataSources.Add(

             new Microsoft.Reporting.WinForms.ReportDataSource("EstudiantesDataSet",estudiantes.Grupos));
            


            viewer.EstudiantesreportViewer.LocalReport.Refresh();

            viewer.Show();
            
        }

    }
}

