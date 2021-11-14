using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class ProductosReportesController : ProductosController
    {
        string archivo = Directory.GetCurrentDirectory() + "\\ReporteProductos.html";
        List<ProductosModel> lista;

        public String Reporte()
        {
            StreamWriter temp = new StreamWriter(archivo);

            //Inicio del archivo
            temp.WriteLine("<html> REPORTE DE PRODUCTOS");
            temp.WriteLine("<table border=1 cellspacing=0>");

            //Columnas
            temp.WriteLine("<tr>" +
                "<td>Id_Producto</td>" +
                "<td>Producto</td>" +
                "<td>Precio</td>" +
                "<td>Existencia</td>" +
                "</tr>");

            //Filas
            lista = Consultar(0);

            foreach (ProductosModel item in lista)
            {
                temp.WriteLine("<tr>");

                temp.WriteLine("<td>" + item.Id_producto + "</td>");
                temp.WriteLine("<td>" + item.Producto + "</td>");
                temp.WriteLine("<td>" + item.Precio + "</td>");
                temp.WriteLine("<td>" + item.Existencia + "</td>");

                temp.WriteLine("</tr>");
            }

            //Fin del archivo
            temp.WriteLine("</table><html>");
            temp.Close();

            return archivo;
        }
    }
}
