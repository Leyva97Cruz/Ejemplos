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
    public partial class TablaMercancia : Form
    {

        CN_Mercancia Mercancia = new CN_Mercancia();


        private string idMercancia=null;
        private bool Editar = false;



        private void Privilegios()//Privilegios
        {
            if (Program.Tipo!="Administrador")
            {
                BtnGuardar.Visible = false;
                BtnEditar.Visible = false;
                BtnEliminar.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                TxtNombre.Visible = false;
                TxtCantidad.Visible = false;
                TxtPrecio.Visible = false;
            }
        }


        public TablaMercancia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//cerra tabla mercancia
        {
            this.Close();
        }

        private void MostrarMercancia()//funcion mostrar mercancia
        {
            CN_Mercancia objeto = new CN_Mercancia();
            TablaMer.DataSource= objeto.MostrarUsuarios();
        }

        private void TablaMercancia_Load(object sender, EventArgs e)//tabala cargando
        {
            MostrarMercancia();
            Privilegios();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)//boton guardar y editar
        {
            if (Editar==false)
            {
                try
                {
                    //---------Declarar Variables -----------------
                    int cantidad;
                    double precio, pagado, Totalporpagar, total;
                    //---------Utilizar Variables------------------
                    cantidad = int.Parse(TxtCantidad.Text); //
                    precio = double.Parse(TxtPrecio.Text);//
                    pagado = 12.1;//
                    //---------Operaciones-------------------------
                    total = cantidad * precio;//
                    Totalporpagar = total - pagado;//
                    //---------Conversion A Texto------------------
                    string Total, totalporPagar;
                    Total = Convert.ToString(total);
                   totalporPagar = Convert.ToString(Totalporpagar);
                    //--------Utilizar el objeto cn----------------
                    Mercancia.InsertarMercancia(TxtNombre.Text, TxtCantidad.Text,null, TxtPrecio.Text, totalporPagar, Total,null);
                    MessageBox.Show("Se Agrego Fila Corectamente ");
                    MostrarMercancia();
                    Limpiar();

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
                    //---------Declarar Variables -----------------
                    int cantidad;
                    double precio, pagado, Totalporpagar, total;
                    //---------Utilizar Variables------------------
                    cantidad = int.Parse(TxtCantidad.Text); //
                    precio = double.Parse(TxtPrecio.Text);//
                    pagado = 12.1;//
                    //---------Operaciones-------------------------
                    total = cantidad * precio;//
                    Totalporpagar = total - pagado;//
                    //---------Conversion A Texto------------------
                    string Total, totalporPagar;
                    Total = Convert.ToString(total);
                    totalporPagar = Convert.ToString(Totalporpagar);
                    //--------Utilizar el objeto cn----------------
                    Mercancia.ActualizarMercancia(TxtNombre.Text, TxtCantidad.Text, null,null,TxtPrecio.Text, totalporPagar, Total, idMercancia);
                    MessageBox.Show("Se Actualizo Fila Corectamente ");
                    MostrarMercancia();
                    Limpiar();

                }
                catch (Exception Ex )
                {

                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void Limpiar()//funcion limpiar
        {
            TxtNombre.Clear();
            TxtCantidad.Clear();
            TxtPrecio.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e) //boton editar
        {
            if (TablaMer.SelectedRows.Count>0)
            {
                try
                {
                    Editar = true;
                    TxtNombre.Text      = TablaMer.CurrentRow.Cells["Nombre"].Value.ToString();
                    TxtCantidad.Text    = TablaMer.CurrentRow.Cells["Cantidad"].Value.ToString();
                    //TxtTipo.Text        = TablaMer.CurrentRow.Cells["Tipo_De_Servicio"].Value.ToString();
                    TxtPrecio.Text      = TablaMer.CurrentRow.Cells["Precio"].Value.ToString();
                    //TxtTotalPagado.Text = TablaMer.CurrentRow.Cells["Total_Pagado"].Value.ToString();
                    idMercancia         = TablaMer.CurrentRow.Cells["ID_Mercancia"].Value.ToString();
            }
                catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }
            else
            {
                MessageBox.Show("Selecione La Fila A Editar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)//boton Eliminar
        {
            if (TablaMer.SelectedRows.Count > 0)
            {
                try
                {
                    idMercancia = TablaMer.CurrentRow.Cells["ID_Mercancia"].Value.ToString();
                    Mercancia.EliminarMercancia(idMercancia);
                    MessageBox.Show("Se Elimino Fila Correctamente");
                    MostrarMercancia();
                    
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Selecione La Fila A Eliminar");
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)//Boton Exportar
        {
            //objeto.ExportarTabla(TablaMer,LblTotaPorPagar.Text,LbTotalPagado.Text,LblTotal.Text);
        }
    }
}
