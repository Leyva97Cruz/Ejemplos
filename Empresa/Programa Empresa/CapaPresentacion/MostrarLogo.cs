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
    public partial class MostrarLogo : Form
    {
        public MostrarLogo()
        {
            InitializeComponent();
        }
        CN_Sumas objetoCN = new CN_Sumas();

        private void Totales()
        {
            objetoCN.Totales(LbTotalPorPagar, LbTotalPagado, LbTotal, LbTotalMercancia);
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lbfecha.Text = DateTime.Now.ToLongDateString();
            lbhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void MostrarLogo_Load(object sender, EventArgs e)
        {
            Totales();
        }
    }
}
