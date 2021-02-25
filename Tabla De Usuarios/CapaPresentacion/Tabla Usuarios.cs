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
    public partial class Form1 : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private string ID = null;
        private bool EDITAR=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        //Se crea una funcion mostrar productos
        private void MostrarProductos()
        {
           CN_Usuarios objeto = new CN_Usuarios();
            TabaUsuarios.DataSource = objeto.MostrarUsu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EDITAR == false)
            {
                try
                {
                    objetoCN.Insertar(txtnombre.Text, textBox1.Text, txtusuario.Text, txtcontraseña.Text);
                    MessageBox.Show("si me salio");
                    MostrarProductos();
                    Limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no salo por que " + ex.Message);

                }
            }
            if (EDITAR==true)
            {
                try
                {
                    objetoCN.Editar(txtnombre.Text, textBox1.Text, txtusuario.Text, txtcontraseña.Text,ID);
                    MessageBox.Show("si se puede editar");
                    MostrarProductos();
                    Limpiar();
                    EDITAR = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("no se pudo editar por que " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (TabaUsuarios.SelectedRows.Count > 0)
                {
                    EDITAR = true;
                    txtnombre.Text = TabaUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                    textBox1.Text = TabaUsuarios.CurrentRow.Cells["Tipo_De_Usuario"].Value.ToString();
                    txtusuario.Text = TabaUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                    txtcontraseña.Text = TabaUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                    ID=TabaUsuarios.CurrentRow.Cells["Id"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("selcione la columna a editar");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("no se puede editar la columna debido a " + ex.Message);
            }
        }

        private void Limpiar()
        {
            textBox1.Clear();
            txtnombre.Clear();
            txtcontraseña.Clear();
            txtusuario.Clear();
            txtnombre.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TabaUsuarios.SelectedRows.Count > 0)
            {
                ID = TabaUsuarios.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.eliminar(ID);
                MessageBox.Show("Se elimino correctamente");
                MostrarProductos();
            }
            else
            {

            }

        }
    }
}
