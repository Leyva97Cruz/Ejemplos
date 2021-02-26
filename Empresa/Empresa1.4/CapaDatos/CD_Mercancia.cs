using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Mercancia
    {

        private CD_Conexion Conexion = new CD_Conexion();
        private SqlDataReader leer;
        SqlCommand Comando = new SqlCommand();
        DataTable tabla = new DataTable();

        public DataTable MostrarMercacnia()  //funcion Mostrar Mercancia
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarMercancia";
            Comando.CommandType = CommandType.StoredProcedure;
            leer = Comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerraConexion();
            return tabla;
        }

        public void listar(DataGridView TABLA)//funcion listar mercacia para poder buscar los datos
        {
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("MostrarMercancia", Conexion.AbrirConexion());
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tbl = new DataTable();
                datos.Fill(tbl);
                TABLA.DataSource = tbl;

                TABLA.Columns[0].HeaderCell.Value = "ID_Mercancia";
                TABLA.Columns[1].HeaderCell.Value = "Nombre";
                TABLA.Columns[2].HeaderCell.Value = "Cantidad";
                TABLA.Columns[3].HeaderCell.Value = "Tipo_De_Servicio";
                TABLA.Columns[4].HeaderCell.Value = "Precio";
                TABLA.Columns[5].HeaderCell.Value = "Total_Por_Pagar";
                TABLA.Columns[6].HeaderCell.Value = "Total_Pagado";
                TABLA.Columns[7].HeaderCell.Value = "Total";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.CerraConexion();
            }
        }

        public void Filtrar(DataGridView TBL, string tipo) //funcion para buscar los datos de la tabla mercancia
        {
            try
            {
                SqlCommand COMANDO = new SqlCommand("Buscar", Conexion.AbrirConexion());
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = tipo;
                COMANDO.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(COMANDO);
                da.Fill(dt);
                TBL.DataSource = dt;
                Conexion.CerraConexion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void InsertarMercancia(string Nombre,int Cantidad,string Tipo,double Precio,double TotalporPagar,double TotalPagado,double Total)//Funcion Insertar Mercancia
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "IsertarMercancia";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            Comando.Parameters.AddWithValue("@TipoDS", Tipo);
            Comando.Parameters.AddWithValue("@Precio", Precio);
            Comando.Parameters.AddWithValue("@TotalPp", TotalporPagar);
            Comando.Parameters.AddWithValue("@TotalP", TotalPagado);
            Comando.Parameters.AddWithValue("@Total", Total);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public void ActualizarMercancia(string Nombre, int Cantidad, string Tipo, double Precio, double TotalporPagar, double TotalPagado, double Total,int Id) //Funcion Actualizar Mercancia
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ActualizarMercancia";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            Comando.Parameters.AddWithValue("@TipoDS", Tipo);
            Comando.Parameters.AddWithValue("@Precio", Precio);
            Comando.Parameters.AddWithValue("@TotalPp", TotalporPagar);
            Comando.Parameters.AddWithValue("@TotalP", TotalPagado);
            Comando.Parameters.AddWithValue("@Total", Total);
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public void EliminarMercancia(int Id) //funcion Eliminar Mercancia
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "EliminarMercancia";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
    }
}
