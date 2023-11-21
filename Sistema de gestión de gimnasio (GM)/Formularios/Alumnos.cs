using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.Drawing.Text;

namespace Sistema_de_gestión_de_gimnasio__GM_.Formularios
{
    public partial class Alumnos : Form
    {
        CN_Alumnos alumnado = new CN_Alumnos();

        public bool Editar = false; 

        Capa_soporte.caché.Alumnos alumnos = new Capa_soporte.caché.Alumnos(); 

        public Alumnos()
        {
            InitializeComponent();
        }

        //solo numero
        public void onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            return;
        }

        //solo letras
        public void onlyLetter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
           
            MostrarAlumnos();
        }

        //mostrar alumnos datagridview
        private void MostrarAlumnos()
        {
            dataGridView1.DataSource = alumnado.MostrarAlumno();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGuardarAlumnosForm_Click(object sender, EventArgs e)
        {
            if (Editar == false)

            {
                //Insertar 
                try
                {
                    alumnado.InsertarAlumno(txtNombreAlumnosForm.Text, txtApellidoAlumnosForm.Text, txtNumTelAlumnosForm.Text, txtContAlleAlumnosForm.Text, txtDNIAlumnosForm.Text, cbxPagoCuotaAlumnosForm.Text);
                    MessageBox.Show("Se insertó correctamente");
                    LlenarData();
                    LimpiarForm(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos" + ex);
                }
            }
            //Modificar 
            if (Editar == true)
            {
                alumnado.ModificarAlumno(txtNombreAlumnosForm.Text, txtApellidoAlumnosForm.Text, txtNumTelAlumnosForm.Text, txtContAlleAlumnosForm.Text, txtDNIAlumnosForm.Text, cbxPagoCuotaAlumnosForm.Text, alumnos.id);
                CN_Alumnos cnalumnos = new CN_Alumnos();
               
                dataGridView1.Refresh();
                LlenarData();
                LimpiarForm(); 
                Editar = false;
            }
        }
        //refrescar
        private void LlenarData()
        {
            dataGridView1.DataSource = alumnado.ListarAlumnos();
        }

        private void cbxPagoCuotaAlumnosForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreAlumnosForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menú menu = new Menú();

            this.Hide();
            menu.ShowDialog();
        }

        //modificar alumno button
        private void btnModificarAlumnos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombreAlumnosForm.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidoAlumnosForm.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                txtNumTelAlumnosForm.Text = dataGridView1.CurrentRow.Cells["NumeroTelefono"].Value.ToString();
                txtContAlleAlumnosForm.Text = dataGridView1.CurrentRow.Cells["numAllegado"].Value.ToString();
                txtDNIAlumnosForm.Text = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
                cbxPagoCuotaAlumnosForm.Text = dataGridView1.CurrentRow.Cells["PagoCuota"].Value.ToString();
                alumnos.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString()); 
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        //vaciar campos form
        private void LimpiarForm()
        {
            txtNombreAlumnosForm.Clear();
            txtApellidoAlumnosForm.Clear ();
            txtNumTelAlumnosForm.Clear ();
            txtContAlleAlumnosForm.Clear () ;
            txtDNIAlumnosForm .Clear ();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //eliminar button
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                alumnos.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                try
                {
                    alumnado.EliminarAlumno(alumnos.id);
                    MessageBox.Show("Se eliminó correctamente");
                    LlenarData();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos" + ex);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}