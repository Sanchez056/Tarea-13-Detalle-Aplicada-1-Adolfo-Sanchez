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
using DAL;
namespace EjemploDetalle.Registros
{
    public partial class RegistrosGrupos : Form
    {
        public RegistrosGrupos()
        {
            InitializeComponent();
           //LLenarCombo();
          

        }
        Utilidades ut = new Utilidades();
        Estudiantes est = new Estudiantes();
        Grupos grup = new Grupos();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Estudiantes que desea buscar") && ValidarBuscar())
                Llenar(GruposBLL.Buscar(ut.StringToInt(GrupoIdtextBox.Text)));


        }

    
        private void Llenar(Grupos g)
        {
           

            GrupoIdtextBox.Text = g.GrupoId.ToString();
            NombrestextBox.Text = g.Nombres;
            //EstuGruposdataGridView.DataSource = GruposBLL.GetListaGrupos(ut.StringToInt(GrupoIdtextBox.Text));
            

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Grupos cliente = new Grupos();
            BuscarerrorProvider.Clear();
            LlenarClase(cliente);
            if (ValidarTextbox() && ValidarExiste(NombrestextBox.Text))
            {
                GruposBLL.Insertar(cliente);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }

           
        }
        Estudiantes Es =new Estudiantes();
        private void LlenarClase(Grupos grupos)
        {
            grupos.Nombres= NombrestextBox.Text;
            grupos.Estudiantes = grupos.Estudiantes;
            SeleEstudiantescomboBox.DataSource = EstudiantesBLL.GetLista();
            

        }
        private void Limpiar()
        {
            GrupoIdtextBox.Clear();
            NombrestextBox.Clear();
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Estudiante que desea eliminar") && ValidarBuscar())
            {
                GruposBLL.Eliminar(ut.StringToInt(GrupoIdtextBox.Text));
                Limpiar();
                SeleEstudiantescomboBox.DataSource = EstudiantesBLL.GetLista();
                MessageBox.Show("Se Elimino Corretamente");

            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RegistrosGrupos_Load(object sender, EventArgs e)
        {
            LLenarCombo();
        }
        public List<Estudiantes> lista = new List<Estudiantes>();

        private void  LLenarCombo()
        {


            SeleEstudiantescomboBox.DataSource = EstudiantesBLL.GetLista();
            SeleEstudiantescomboBox.DisplayMember = "Nombres";
            SeleEstudiantescomboBox.ValueMember = "EstudianteId";



        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombrestextBox.Text) &&
                string.IsNullOrEmpty(EstuGruposdataGridView.Text)

                )
            {
               NombreserrorProvider.SetError(NombrestextBox, "Favor Ingresar el Nombre de Estudiantes");

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombrestextBox.Text))
            {
                NombreserrorProvider.Clear();
                NombreserrorProvider.SetError(NombrestextBox, "Favor ingresar el Nombre del Estudiantes");
                return false;
            }
            
            return true;
        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(GrupoIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarBuscar()
        {
            if (GruposBLL.Buscar(ut.StringToInt(GrupoIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }

        private bool ValidarExiste(string aux)
        {
            if (GruposBLL.GetListaNombres(aux).Count() > 0)
            {
                MessageBox.Show("Este Nombre  ya existe, favor intentar con otra Nombre ...");
                return false;
            }
            return true;
        }
        //-----
        private void limpiarErroresProvider()
        {
           NombreserrorProvider.Clear();


        }


        private void SeleEstudiantescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        Grupos grupos = new Grupos();
        //Estudiantes estudiantes = new Estudiantes();
        private void Insertarbutton_Click(object sender, EventArgs e)
        {
            grupos.Estudiantes.Add(new Estudiantes((int)SeleEstudiantescomboBox.SelectedValue, SeleEstudiantescomboBox.Text));
            EstuGruposdataGridView.DataSource = null;
            EstuGruposdataGridView.DataSource = grupos.Estudiantes;


        }

        
    }
}


