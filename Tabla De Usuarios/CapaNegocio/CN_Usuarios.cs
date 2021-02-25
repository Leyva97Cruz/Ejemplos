using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos; 


namespace CapaNegocio
{
   public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

//mostrar datos de la tabla

        public DataTable MostrarUsu()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        //insertar datos de la tabla
        public void Insertar(string nombre, string tipod, string usu, string contra)
        {
            objetoCD.Insertar(nombre, tipod, usu, contra);


        }

        //editar columnas

        public void Editar(string nombre, string tipod, string usu, string contra,string id)
        {
            objetoCD.Editar(nombre, tipod, usu, contra,Convert.ToInt32(id));
        }

        public void eliminar(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
