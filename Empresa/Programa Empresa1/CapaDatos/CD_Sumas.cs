using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using CapaDatos.Properties;
using System.Configuration;


namespace CapaDatos
{
    public class CD_Sumas
    {
        //public static string ObtenerString()
        //{
        //    return Settings.Default.EmpresasConnectionString;
        //}
        //private SqlConnection conexion = new SqlConnection(ObtenerString());
        private SqlConnection conexion = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;DataBase=Empresas; integrated security = true");
        SqlCommand Comando;

        public void sumas (Label TotalPp,Label TotalP,Label Total,Label TotalM)//funcion para mostar datos suma de la tabla mercacnia
        {
            Comando = new SqlCommand("SUMAS_De_Columnas",conexion);
            Comando.CommandType = CommandType.StoredProcedure;
            SqlParameter TtlPorpagar = new SqlParameter("@TotalPorPagar", 0);TtlPorpagar.Direction = ParameterDirection.Output;
            SqlParameter TtlPagado = new SqlParameter("@TotalPagado", 0);TtlPagado.Direction = ParameterDirection.Output;
            SqlParameter Ttl = new SqlParameter("@Total", 0);Ttl.Direction = ParameterDirection.Output;
            SqlParameter TtlMercancia = new SqlParameter("@CantidadMercancia", 0);TtlMercancia.Direction = ParameterDirection.Output;
            Comando.Parameters.Add(TtlPorpagar);
            Comando.Parameters.Add(TtlPagado);
            Comando.Parameters.Add(Ttl);
            Comando.Parameters.Add(TtlMercancia);
            conexion.Open();
            Comando.ExecuteNonQuery();
            TotalPp.Text = Comando.Parameters["@TotalPorPagar"].Value.ToString();
            TotalP.Text = Comando.Parameters["@TotalPagado"].Value.ToString();
            Total.Text = Comando.Parameters["@Total"].Value.ToString();
            TotalM.Text = Comando.Parameters["@CantidadMercancia"].Value.ToString();
            conexion.Close();
        }
         
    }
}
