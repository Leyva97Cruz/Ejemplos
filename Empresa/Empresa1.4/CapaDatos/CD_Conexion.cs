using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using CapaDatos.Properties;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public  class CD_Conexion
    {
        
        MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; port=3306; user id=Usuario1; password=FOrtachon97; database=practica;");
        private SqlConnection conexion = new SqlConnection("data source=192.168.1.80,1433;Initial Catalog=Empresas;user id=Usuario1;password=123");


        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)

                conexion.Open();
            return conexion;

        }

        public MySqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)

                Conexion.Open();
            return Conexion;
        }

        //cerrar conexion

        public SqlConnection CerraConexion()
        {
            if (conexion.State == ConnectionState.Open)

                conexion.Close();
            return conexion;

        }
        
        public MySqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)

                Conexion.Close();
            return Conexion;
        }


    }
}
