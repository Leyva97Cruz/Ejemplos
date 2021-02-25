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
    public partial class tablas : Form
    {
        public tablas()
        {
            InitializeComponent();
        }

        private void dATOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dATOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void tablas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDataSet.DATOS' Puede moverla o quitarla según sea necesario.
            this.dATOSTableAdapter.Fill(this.baseDataSet.DATOS);

        }
    }
}
