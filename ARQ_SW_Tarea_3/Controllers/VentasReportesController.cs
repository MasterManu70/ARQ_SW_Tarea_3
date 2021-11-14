using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class VentasReportesController : VentasController
    {
        string archivo = Directory.GetCurrentDirectory() + "\\ReporteVentas.html";
        List<VentasModel> lista;

        public String Reporte()
        {
            StreamWriter temp = new StreamWriter(archivo);

            //Inicio del archivo
            temp.WriteLine("<html> REPORTE DE VENTAS");
            temp.WriteLine("<table border=1 cellspacing=0>");

            //Columnas
            temp.WriteLine("<tr>" +
                "<td>Id_Venta</td>" +
                "<td>id_Cliente</td>" +
                "<td>Id_Producto</td>" +
                "<td>FechaVenta</td>" +
                "<td>Cantidad</td>" +
                "<td>PrecioVenta</td>" +
                "</tr>");

            //Filas
            lista = Consultar(0);

            foreach (VentasModel item in lista)
            {
                temp.WriteLine("<tr>");

                temp.WriteLine("<td>" + item.Id_Venta + "</td>");
                temp.WriteLine("<td>" + item.Id_Cliente + "</td>");
                temp.WriteLine("<td>" + item.Id_Producto + "</td>");
                temp.WriteLine("<td>" + item.FechaVenta + "</td>");
                temp.WriteLine("<td>" + item.Cantidad + "</td>");
                temp.WriteLine("<td>" + item.PrecioVenta + "</td>");

                temp.WriteLine("</tr>");
            }

            //Fin del archivo
            temp.WriteLine("</table><html>");
            temp.Close();

            return archivo;
        }
    }
}
