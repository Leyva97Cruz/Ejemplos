using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

 class Class1
 {
    private SqlConnection conexion = new SqlConnection("Server=AARONLEYVACRUZ\\TEW_SQLEXPRESS;DataBase=Datos; integrated security = true");

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
