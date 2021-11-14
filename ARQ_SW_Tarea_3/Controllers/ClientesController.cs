using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class ClientesController : Conexion
    {
        public List<ClientesModel> Consultar(int id)
        {
            List<ClientesModel> lista = new List<ClientesModel>();

            try
            {
                Conectar();
                SqlCommand comando = new SqlCommand("sp_clientes_consultar", cnn);
                comando.Parameters.AddWithValue("@Id_cliente", id);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ClientesModel modelo = new ClientesModel()
                    {
                        Id_cliente = int.Parse(lector[0] + ""),
                        Cliente = lector[1] + "",
                        Domicilio = lector[2] + "",
                        Celular = lector[3] + ""
                    };
                    lista.Add(modelo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }

        public void Guardar(ClientesModel modelo)
        {
            SqlCommand comando;

            try
            {
                Conectar();
                if (modelo.Id_cliente != 0)
                {
                    comando = new SqlCommand("sp_clientes_modificar", cnn);
                    comando.Parameters.AddWithValue("@Id_cliente", modelo.Id_cliente);
                }
                else
                    comando = new SqlCommand("sp_clientes_agregar", cnn);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Cliente", modelo.Cliente);
                comando.Parameters.AddWithValue("@Domicilio", modelo.Domicilio);
                comando.Parameters.AddWithValue("@Celular", modelo.Celular);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void Eliminar(int id)
        {
            SqlCommand comando;

            try
            {
                Conectar();
                comando = new SqlCommand("sp_clientes_eliminar", cnn);
                comando.Parameters.AddWithValue("@Id_cliente", id);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
