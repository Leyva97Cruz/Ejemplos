using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, contraseña;
           usuario = textBox1.Text;
            contraseña = textBox2.Text;

            if (usuario=="admin" & contraseña=="12345678")
            {
                MessageBox.Show("Contraseña Correcta");
                tablas form = new tablas();
                form.Show();

            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");

            }
             if (usuario == "admin1" & contraseña == "1234567")
            {
                MessageBox.Show("Contraseña Correcta");
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");

            }
            if (usuario == "admin2" & contraseña == "123456")
            {
                MessageBox.Show("Contraseña Correcta");
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
            if (usuario == "admin3" & contraseña == "12345")
            {
                MessageBox.Show("Contraseña Correcta");
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }
    }
}
