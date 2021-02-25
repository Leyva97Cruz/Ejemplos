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
    public partial class BuscarMercancia : Form
    {
        public BuscarMercancia()
        {
            InitializeComponent();
        }

        private CN_Mercancia objeto = new CN_Mercancia();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarMercancia_Load(object sender, EventArgs e)
        {
            objeto.ListarMercancia(Tablabuscar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            objeto.buscar(Tablabuscar, this.textBox1.Text.Trim());
        }
    }
}
