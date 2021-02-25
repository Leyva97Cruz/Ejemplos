using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class TablaUsuarios : Form
    {
        CN_Usuarios ObjetoCN = new CN_Usuarios();
        private string idUsuarios = null;
        private bool Editar = false;

        public TablaUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios() // funcion mostrar usuarios
        {
            CN_Usuarios objeto = new CN_Usuarios();
            TablaUsu.DataSource = objeto.MostrarUsuario();
        }

        private void Form1_Load(object sender, EventArgs e) //funcion de cargara
        {
            MostrarUsuarios();
        }

        private void pictureBox1_Click(object sender, EventArgs e)   //Cerra el formulario
        {
            this.Close();
        }

        private void TablaUsu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) //formato condicionl de celdas
        {
            if (this.TablaUsu.Columns[e.ColumnIndex].Name == "Tipo_De_Usuario")
            {
                if (e.Value.Equals( "Administrador"))
                {
                    e.CellStyle.ForeColor = Color.DarkRed;
                }

                if (e.Value.Equals("Usuario"))
                {
                    e.CellStyle.ForeColor = Color.DarkBlue;
                }

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e) //Boton para agrgar y editar los usuarios
        {
            string Combo = Convert.ToString(CboTipo.SelectedItem);
            if (Editar == false)
            {
                try
                {
                    ObjetoCN.InsertarUsuarios(TxtNombre.Text, Combo, TxtUsuario.Text, TxtContraseña.Text);
                    MessageBox.Show("Se Agrego Usuario Correctamente");
                    MostrarUsuarios();
                    limpiar();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }

            if (Editar==true)
            {
                try
                {
                    ObjetoCN.ActualizarUsuarios(TxtNombre.Text, Combo, TxtUsuario.Text, TxtContraseña.Text, idUsuarios);
                    MessageBox.Show("Se Actualizo Correctamente El Usuario");
                    MostrarUsuarios();
                    Editar = false;
                    limpiar();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void BtnEditar_Click(object sender, EventArgs e) //Boton Editar Usuarios
        {
            try
            {
                if (TablaUsu.SelectedRows.Count>0)
                {
                    Editar = true;
                    TxtNombre.Text     =  TablaUsu.CurrentRow.Cells["Nombre"].Value.ToString();
                    CboTipo.Text       =  TablaUsu.CurrentRow.Cells["Tipo_De_Usuario"].Value.ToString();
                    TxtUsuario.Text    =  TablaUsu.CurrentRow.Cells["Usuario"].Value.ToString();
                    TxtContraseña.Text =  TablaUsu.CurrentRow.Cells["Contraseña"].Value.ToString();
                    idUsuarios         =  TablaUsu.CurrentRow.Cells["ID_Usuarios"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Seleccione El Usuario A Editar");
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

           
        }

        private void limpiar() //funcion limpiar
        {
            TxtNombre.Clear();
            TxtUsuario.Clear();
            TxtContraseña.Clear();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TablaUsu.SelectedRows.Count>0)
                {
                    idUsuarios = TablaUsu.CurrentRow.Cells["Id"].Value.ToString();
                    ObjetoCN.EliminarUsuarios(idUsuarios);
                    MessageBox.Show("Se Elimino Usuario Corectamente");
                    MostrarUsuarios();

                }
                else
                {
                    MessageBox.Show("Selecione la Fila A Eliminar");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                
            }
        }
    }
}
