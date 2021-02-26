using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using CapaDatos.Properties;
using System.Configuration;


namespace CapaDatos
{
    public  class CD_Conexion
    {

        private SqlConnection conexion = new SqlConnection("data source=192.168.1.80,1433;Initial Catalog=Empresas;user id=Usuario1;password=123");


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
