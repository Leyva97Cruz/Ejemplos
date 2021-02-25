using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    class CD_Conexion
    {
        //               servidor                     nombre dla base        confirmacion de windows
        private SqlConnection conexion = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;DataBase=TbUsuarios ;integrated security = true");

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
