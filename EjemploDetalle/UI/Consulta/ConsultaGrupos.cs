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
    public partial class ConsultaGrupos : Form
    {
        Estudiantes estud = new Estudiantes();
        Utilidades ut = new Utilidades();
        public ConsultaGrupos()
        {
            InitializeComponent();
        }

        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "EstudianteId");
            FiltrarcomboBox.Items.Insert(1, "Nombres");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";

        }
        private void LlenarId(Grupos g)
        {

            var grup = GruposBLL.Buscar(ut.StringToInt(FiltrotextBox.Text));
            FiltrotextBox.Text = g.GrupoId.ToString();
            NombreGrupotextBox.Text= g.Nombres;
            ConsultaGruposdataGridView.DataSource = null;
            ConsultaGruposdataGridView.DataSource = g.Estudiantes;

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LlenarId(GruposBLL.Buscar(ut.StringToInt(FiltrotextBox.Text)));

        }

        private void ConsultaGrupos_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReporGrupos viewer = new ReporGrupos();

            viewer.GruposreportViewer.Reset();
            viewer.GruposreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.GruposreportViewer.LocalReport.ReportPath = @"D:\Tarea de Aplicada 1\Tarea#12 EjemploDetalle Adolfo Sanchez\EjemploDetalle\EjemploDetalle\Reportes\ListadosGrupos.rdlc";


            viewer.GruposreportViewer.LocalReport.DataSources.Clear();
           

            viewer.GruposreportViewer.LocalReport.DataSources.Add(

            new Microsoft.Reporting.WinForms.ReportDataSource("EstudiantesDataSet", EstudiantesBLL.GetLista()));

            // var est = EstudiantesBLL.Buscar(ut.StringToInt(FiltrotextBox.Text));


            viewer.GruposreportViewer.LocalReport.Refresh();

            viewer.Show();


        }
    }
}
