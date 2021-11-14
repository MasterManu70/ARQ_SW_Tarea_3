using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class ProductosController : Conexion
    {
        public List<ProductosModel> Consultar(int id)
        {
            List<ProductosModel> lista = new List<ProductosModel>();

            try
            {
                Conectar();
                SqlCommand comando = new SqlCommand("sp_productos_consultar", cnn);
                comando.Parameters.AddWithValue("@Id_producto", id);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ProductosModel modelo = new ProductosModel()
                    {
                        Id_producto = int.Parse(lector[0] + ""),
                        Producto = lector[1] + "",
                        Precio = double.Parse(lector[2] + ""),
                        Existencia = int.Parse(lector[3] + "")
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

        public void Guardar(ProductosModel modelo)
        {
            SqlCommand comando;

            try
            {
                Conectar();
                if (modelo.Id_producto != 0)
                {
                    comando = new SqlCommand("sp_productos_modificar", cnn);
                    comando.Parameters.AddWithValue("@Id_producto", modelo.Id_producto);
                }
                else
                    comando = new SqlCommand("sp_productos_agregar", cnn);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Producto", modelo.Producto);
                comando.Parameters.AddWithValue("@Precio", modelo.Precio);
                comando.Parameters.AddWithValue("@Existencia", modelo.Existencia);

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
                comando = new SqlCommand("sp_productos_eliminar", cnn);
                comando.Parameters.AddWithValue("@Id_producto", id);
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
