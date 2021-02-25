using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private CD_Conexion Conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlDataReader LEER;
        SqlCommand Comando = new SqlCommand();
        DataTable tabla = new DataTable();

        public SqlDataReader Privilegios()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarUsuarios";
            Comando.CommandType = CommandType.StoredProcedure;
            LEER = Comando.ExecuteReader();
            Conexion.CerraConexion();
            return LEER;
        }

        public DataTable MostrarUsuarios() //funcion mostrar usuarios
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarUsuarios";
            Comando.CommandType = CommandType.StoredProcedure;
            leer = Comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerraConexion();
            return tabla;
        }  

        public void InsertarUsuarios(string Nombre,string Tipo,string Usuario ,string Contraseña) //funcion Insertar Usuarios
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarUsuarios";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Tipo", Tipo);
            Comando.Parameters.AddWithValue("@Usuario", Usuario);
            Comando.Parameters.AddWithValue("@Contraseña", Contraseña);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }


        public void ActualizarUsuarios(string Nombre, string Tipo, string Usuario, string Contraseña,int Id)  //Funcion Eliminar
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ActualizarUsuarios";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Tipo", Tipo);
            Comando.Parameters.AddWithValue("@Usuario", Usuario);
            Comando.Parameters.AddWithValue("@Contraseña", Contraseña);
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }


        public void EliminarUsuarios(int Id) //Funcion Eliminar Usuarios
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "EliminarUsuarios";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

    }
}
