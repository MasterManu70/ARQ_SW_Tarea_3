using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class UsuariosRerpotesController : UsuariosController
    {
        string archivo = Directory.GetCurrentDirectory() + "\\ReporteUsuarios.html";
        List<UsuariosModel> lista;

        public String Reporte()
        {
            StreamWriter temp = new StreamWriter(archivo);

            //Inicio del archivo
            temp.WriteLine("<html> REPORTE DE USUARIOS");
            temp.WriteLine("<table border=1 cellspacing=0>");

            //Columnas
            temp.WriteLine("<tr>" +
                "<td>ID_Usuario</td>" +
                "<td>Usuario</td>" +
                "<td>Correo</td>" +
                "<td>Celular</td>" +
                "</tr>");

            //Filas
            lista = Consultar(0);

            foreach (UsuariosModel item in lista)
            {
                temp.WriteLine("<tr>");

                temp.WriteLine("<td>" + item.Id_usuario + "</td>");
                temp.WriteLine("<td>" + item.Usuario + "</td>");
                temp.WriteLine("<td>" + item.Correo + "</td>");
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
