using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //mostrar datos de la tabla
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;                                                          //"select *from Usuarios";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerraConexion();
            return tabla;

        }
        //insertar datos de la tabla
        public void Insertar(string nombre, string tipod, string usu, string contra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insetar";                                                                                     //"insert into  Usuarios values('"+nombre+"','"+tipod+"','"+usu+"','"+contra+"')";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre); 
            comando.Parameters.AddWithValue("@tipo", tipod);
            comando.Parameters.AddWithValue("@usuario", usu);
            comando.Parameters.AddWithValue("@contraseña", contra);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //editar datos de la tabla
        public void Editar(string nombre, string tipod, string usu, string contra,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Editar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@tipo", tipod);
            comando.Parameters.AddWithValue("@usuario", usu);
            comando.Parameters.AddWithValue("@contraseña", contra);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //eliminar datos de la tabla
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idU", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
