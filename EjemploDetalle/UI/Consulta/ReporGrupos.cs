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
    public partial class ReporGrupos : Form
    {
        public ReporGrupos()
        {
            InitializeComponent();
        }

        private void ReporGrupos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
