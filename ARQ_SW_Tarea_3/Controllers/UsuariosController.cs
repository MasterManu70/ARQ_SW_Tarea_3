using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Controllers
{
    class UsuariosController : Conexion
    {
        public List<UsuariosModel> Consultar(int id)
        {
            List<UsuariosModel> lista = new List<UsuariosModel>();

            try
            {
                Conectar();
                SqlCommand comando = new SqlCommand("sp_usuarios_consultar", cnn);
                comando.Parameters.AddWithValue("@Id_usuario", id);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    UsuariosModel modelo = new UsuariosModel()
                    {
                        Id_usuario = int.Parse(lector[0] + ""),
                        Usuario = lector[1] + "",
                        Correo = lector[2] + "",
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

        public void Guardar(UsuariosModel modelo)
        {
            SqlCommand comando;

            try
            {
                Conectar();
                if (modelo.Id_usuario != 0)
                {
                    comando = new SqlCommand("sp_usuarios_modificar", cnn);
                    comando.Parameters.AddWithValue("@Id_usuario", modelo.Id_usuario);
                }
                else
                    comando = new SqlCommand("sp_usuarios_agregar", cnn);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Usuario", modelo.Usuario);
                comando.Parameters.AddWithValue("@Contrasena", modelo.Contrasena);
                comando.Parameters.AddWithValue("@Correo", modelo.Correo);
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
                comando = new SqlCommand("sp_usuarios_eliminar", cnn);
                comando.Parameters.AddWithValue("@Id_usuario", id);
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
