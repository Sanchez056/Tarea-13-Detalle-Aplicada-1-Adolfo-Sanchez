using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDetalle.Consulta
{
    public partial class ReporEstudiantes : Form
    {
        public ReporEstudiantes()
        {
            InitializeComponent();
        }

        private void ReporEstudiantes_Load(object sender, EventArgs e)
        {

            this.EstudiantesreportViewer.RefreshReport();
        }
    }
}
