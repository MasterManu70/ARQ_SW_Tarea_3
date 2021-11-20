using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class VentasController : Conexion
    {
        public List<VentasModel> Consultar(int id)
        {
            List<VentasModel> lista = new List<VentasModel>();

            try
            {
                Conectar();
                SqlCommand comando = new SqlCommand("sp_ventas_consultar", cnn);
                comando.Parameters.AddWithValue("@Id_venta", id);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    VentasModel modelo = new VentasModel()
                    {
                        Id_Venta = int.Parse(lector[0] + ""),
                        Id_Usuario = int.Parse(lector[1] + ""),
                        Id_Producto = int.Parse(lector[2] + ""),
                        FechaVenta = Convert.ToDateTime(lector[3] + ""),
                        Cantidad = int.Parse(lector[4] + ""),
                        PrecioVenta = Convert.ToDouble(lector[5] + "")
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

        public void Guardar(VentasModel modelo)
        {
            SqlCommand comando;

            try
            {
                Conectar();
                if (modelo.Id_Venta != 0)
                {
                    comando = new SqlCommand("sp_ventas_modificar", cnn);
                    comando.Parameters.AddWithValue("@Id_venta", modelo.Id_Venta);
                }
                else
                    comando = new SqlCommand("sp_ventas_agregar", cnn);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id_usuario", modelo.Id_Usuario);
                comando.Parameters.AddWithValue("@Id_producto", modelo.Id_Producto);
                comando.Parameters.AddWithValue("@FechaVenta", modelo.FechaVenta);
                comando.Parameters.AddWithValue("@Cantidad", modelo.Cantidad);
                comando.Parameters.AddWithValue("@PrecioVenta", modelo.PrecioVenta);

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
                comando = new SqlCommand("sp_ventas_eliminar", cnn);
                comando.Parameters.AddWithValue("@Id_venta", id);
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
