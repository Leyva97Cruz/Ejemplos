using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Exportar
    {
        CD_Exportar Objeto = new CD_Exportar();

        public void ExportarTabla (DataGridView Tabla, string TotalPp, string TotalP, string Total)
        {
            Objeto.ExportarTablaMercancia(Tabla,TotalPp,TotalP,Total);
        }

    }
}
