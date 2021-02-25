using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace CapaDatos
{
    public  class CD_Exportar
    {
        public void ExportarTablaMercancia(DataGridView tabla,string TotalPp,string TotalP,string Total)
        {
            try
            {
                SaveFileDialog Fichero = new SaveFileDialog();
                Fichero.Filter = "Excel (*.xlsx)|*xlsx";
                Fichero.FileName = "Libro1";
                if (Fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libro;
                    Microsoft.Office.Interop.Excel.Worksheet hoja;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();

                    libro = aplicacion.Workbooks.Add();
                    hoja = (Microsoft.Office.Interop.Excel.Worksheet)libro.Worksheets.get_Item(1);



                    int valorFila = 0;
                    for (int i = 1; i <= tabla.Columns.Count; i++)
                    {
                        hoja.Cells[1, i] = tabla.Columns[i - 1].HeaderText;

                    }
                    valorFila = valorFila + 1;
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < tabla.Columns.Count; j++)
                        {
                            if ((tabla.Rows[i].Cells[j].Value == null) == false)
                            {

                                hoja.Cells[valorFila + 1, j + 1] = tabla.Rows[i].Cells[j].Value.ToString();


                            }
                        }
                        valorFila++;
                    }
                    int c = tabla.Rows.Count + 3;
                    hoja.Cells[c, 1] = "Total";
                    hoja.Cells[c, 6] = TotalPp;
                    hoja.Cells[c, 7] = TotalP;
                    hoja.Cells[c, 8] = Total;


                    libro.SaveAs(Fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libro.Close(true);
                    aplicacion.Quit();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al exportar debido" + ex.ToString());

            }
        }

    }
}
