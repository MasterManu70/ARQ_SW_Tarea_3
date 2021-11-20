using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3
{
    class Conexion
    {
        protected SqlConnection cnn;

        protected void Conectar()
        {
            try
            {
                cnn = new SqlConnection("Data Source=MM70-DESKTOP;Initial Catalog=Ferreteria;Integrated Security=True;");
                cnn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        protected void Desconectar()
        {
            try
            {
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
