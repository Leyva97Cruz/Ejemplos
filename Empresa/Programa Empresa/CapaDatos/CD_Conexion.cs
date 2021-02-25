using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//using CapaDatos.Properties;
using System.Configuration;


namespace CapaDatos
{
    public  class CD_Conexion
    {
        //public static string ObtenerString()
        //{
        //    return Settings.Default.EmpresasConnectionString;
        //}
        //private SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conectar);
        private SqlConnection conexion = new SqlConnection("Server=.;DataBase=Empresas;Integrated Security=SSPI");
        //private SqlConnection conexion = new SqlConnection(ObtenerString()); ("Server=.;DataBase=DemoPractica;Integrated Security=SSPI")
        //abrir conexion

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)

                conexion.Open();
            return conexion;

        }

        //cerrar conexion

        public SqlConnection CerraConexion()
        {
            if (conexion.State == ConnectionState.Open)

                conexion.Close();
            return conexion;

        }



    }
}
