using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Empleado
    {
        private CD_Conexion Conexion = new CD_Conexion();
        private SqlDataReader leer;
        SqlCommand COMANDO = new SqlCommand();


        public SqlDataReader IniciarSesion (string Usuario,string Contraseña)
        {
            COMANDO.Connection = Conexion.AbrirConexion();
            COMANDO.CommandText = "IniciarSesion";
            COMANDO.CommandType = CommandType.StoredProcedure;
            COMANDO.Parameters.AddWithValue("@Usuario", Usuario);
            COMANDO.Parameters.AddWithValue("@Contraseña", Contraseña);
            leer = COMANDO.ExecuteReader();
            return leer;
        }
    }
}
