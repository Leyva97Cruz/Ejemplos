using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Sumas
    {
        CD_Sumas objeto = new CD_Sumas();

        public void Totales(Label TotalPp, Label TotalP, Label Total, Label TotalM)
        {
            objeto.sumas(TotalPp, TotalP, Total, TotalM);
        }

    }
}
