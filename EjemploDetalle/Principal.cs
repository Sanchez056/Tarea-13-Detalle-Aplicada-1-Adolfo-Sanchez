using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDetalle
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosEstudiantes res = new Registros.RegistrosEstudiantes();
            res.MdiParent = this;
            res.Show();
            res.Location = new Point(130, 10);
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosGrupos res = new Registros.RegistrosGrupos();
            res.MdiParent = this;
            res.Show();
            res.Location = new Point(130, 10);

        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta.ConsultaEstudiantes con= new Consulta.ConsultaEstudiantes();
            con.MdiParent = this;
            con.Show();
            con.Location = new Point(130, 10);
        }

        private void gruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta.ConsultaGrupos con = new Consulta.ConsultaGrupos();
            con.MdiParent = this;
            con.Show();
            con.Location = new Point(130, 10);
        }
    }
    }

