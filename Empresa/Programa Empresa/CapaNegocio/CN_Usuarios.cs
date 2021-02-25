using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios ObjetoDato = new CD_Usuarios();


        public DataTable MostrarUsuario()//Funcion Mostrar Usuarios en la capa de Negocio
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoDato.MostrarUsuarios();
            return tabla;
        }  
       public SqlDataReader Privilegios()
        {
            SqlDataReader leer;
            leer = ObjetoDato.Privilegios();
            return leer;

        }

        public void InsertarUsuarios (string Nombre, string Tipo, string Usuario, string Contraseña)//Funcion Insertar Usuarios en la capa de Negocio
        {
            ObjetoDato.InsertarUsuarios(Nombre, Tipo, Usuario, Contraseña);
        }

        public void ActualizarUsuarios(string Nombre, string Tipo, string Usuario, string Contraseña,string Id)//Funcion Actualizar Usuarios en la capa de Negocio
        {
            ObjetoDato.ActualizarUsuarios(Nombre, Tipo, Usuario, Contraseña, Convert.ToInt32(Id));
        }

        public void EliminarUsuarios(string Id)//Funcion Eliminar Usuarios en la capa de Negocio
        {
            ObjetoDato.EliminarUsuarios(Convert.ToInt32(Id));
        }
    }
}
