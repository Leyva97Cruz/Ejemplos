using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text=="USUARIO")
            {
                txtusuario.Text = "";

            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text=="")
            {
                txtusuario.Text = "USUARIO";
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text=="CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.UseSystemPasswordChar=true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text=="")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Empleado ObjUsuario = new CN_Empleado();
                SqlDataReader loguear;
                ObjUsuario.Usuario = txtusuario.Text;
                ObjUsuario.Contraseña = txtcontraseña.Text;
                loguear = ObjUsuario.IniciarSesion();

                if (loguear.Read() == true)
                {
                    this.Hide();
                    PantallaPrincipal form = new PantallaPrincipal();
                    Program.Tipo = loguear["Tipo_De_Usuario"].ToString();
                    form.Show();
                

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Invalido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (txtcontraseña.Text != "CONTRASEÑA")
            //{
                if (checkBox1.Checked == true && txtcontraseña.UseSystemPasswordChar == true)
                {
                    txtcontraseña.UseSystemPasswordChar = false;
                }
                else
                {
                    txtcontraseña.UseSystemPasswordChar = true;
                }
            //}
        }
    }
}
