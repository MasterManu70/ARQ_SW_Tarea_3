using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class ClientesRerpotesController : ClientesController
    {
        string archivo = Directory.GetCurrentDirectory() + "\\ReporteClientes.html";
        List<ClientesModel> lista;

        public String Reporte()
        {
            StreamWriter temp = new StreamWriter(archivo);

            //Inicio del archivo
            temp.WriteLine("<html> REPORTE DE CLIENTES");
            temp.WriteLine("<table border=1 cellspacing=0>");

            //Columnas
            temp.WriteLine("<tr>" +
                "<td>ID_Cliente</td>" +
                "<td>Cliente</td>" +
                "<td>Domicilio</td>" +
                "<td>Celular</td>" +
                "</tr>");

            //Filas
            lista = Consultar(0);

            foreach (ClientesModel item in lista)
            {
                temp.WriteLine("<tr>");

                temp.WriteLine("<td>" + item.Id_cliente + "</td>");
                temp.WriteLine("<td>" + item.Cliente + "</td>");
                temp.WriteLine("<td>" + item.Domicilio + "</td>");
                temp.WriteLine("<td>" + item.Celular + "</td>");

                temp.WriteLine("</tr>");
            }

            //Fin del archivo
            temp.WriteLine("</table><html>");
            temp.Close();

            return archivo;
        }
    }
}
