using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public  class CD_Conexion
    {
        //public static string ObtenerString()
        //{
        //    return Settings.Default.EmpresasConnectionString;
        //}
        //private SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conectar);
        private SqlConnection conexion = new SqlConnection("Server=AARONLEYVACRUZ;DataBase=Empresas; integrated security = true");
        //private SqlConnection conexion = new SqlConnection(ObtenerString());
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
