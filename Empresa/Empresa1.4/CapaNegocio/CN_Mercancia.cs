using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CN_Mercancia
    {
        private CD_Mercancia ObjetoDato = new CD_Mercancia();

        public void ListarMercancia(DataGridView TABLA) //Funcion Listar en la capa de negocio
        {
            ObjetoDato.listar(TABLA);
        }

        public void buscar(DataGridView TBL, string tipo) //funcion buscar en la capa negocio
        {
            ObjetoDato.Filtrar(TBL, tipo);
        }

        public DataTable MostrarUsuarios() // funcion Mostrar Usuarios en la capa negocio
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoDato.MostrarMercacnia();
            return tabla;
        }

        public void InsertarMercancia(string Nombre, string Cantidad, string Tipo, string Precio, string TotalporPagar, string TotalPagado, string Total) //funcion Insertar mercanica en la capa negocio
        {
            ObjetoDato.InsertarMercancia(Nombre, Convert.ToInt32(Cantidad), Tipo, Convert.ToDouble(Precio), Convert.ToDouble(TotalporPagar), Convert.ToDouble(TotalPagado), Convert.ToDouble(Total));
        }

        public void ActualizarMercancia(string Nombre, string Cantidad, string Tipo, string Precio, string TotalporPagar, string TotalPagado, string Total,string Id)//Funcion Actualizar mercancia en la capa negocio
        {
            ObjetoDato.ActualizarMercancia(Nombre, Convert.ToInt32(Cantidad), Tipo, Convert.ToDouble(Precio), Convert.ToDouble(TotalporPagar), Convert.ToDouble(TotalPagado), Convert.ToDouble(Total),Convert.ToInt32(Id));
          
        }

        public void EliminarMercancia(string Id) //funcion eliminar en la capa de negocio
        {
            ObjetoDato.EliminarMercancia(Convert.ToInt32(Id));
        }


    }
}
