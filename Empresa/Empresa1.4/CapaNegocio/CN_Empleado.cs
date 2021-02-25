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
    public class CN_Empleado
    {
        private CD_Empleado ObjDato = new CD_Empleado();


        private String _Usuario;
        private String _Contraseña;

        public String Usuario
        {
            set { _Usuario = value; }
            get { return _Usuario; }
        }
        public String Contraseña
        {
            set { _Contraseña = value; }
            get { return _Contraseña; }
        }

        public CN_Empleado() { }

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader loguear;
            loguear = ObjDato.IniciarSesion(Usuario, Contraseña);
            return loguear;
        }
    }
}
