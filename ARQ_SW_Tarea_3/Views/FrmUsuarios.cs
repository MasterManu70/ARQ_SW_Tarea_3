using ARQ_SW_Tarea_3.Controllers;
using ARQ_SW_Tarea_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARQ_SW_Tarea_3.Views
{
    public partial class FrmUsuarios : Form
    {
        UsuariosController data = new UsuariosController();
        List<UsuariosModel> lista = new List<UsuariosModel>();
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Columns.Add("Id_usuario", "ID Usuario");
            dgvClientes.Columns.Add("Usuario", "Usuario");
            dgvClientes.Columns.Add("Correo", "Correo");
            dgvClientes.Columns.Add("Celular", "Celular");
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCorreo.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCelular.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //Consultar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar.Text, out int id) && txtBuscar.Text != String.Empty)
            {
                MessageBox.Show("Solo se permiten números enteros como parámetro de búsqueda");
                txtBuscar.Focus();
                return;
            }

            lista = data.Consultar(id);

            dgvClientes.Rows.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron registros");
                return;
            }

            foreach (UsuariosModel item in lista)
            {
                dgvClientes.Rows.Add(
                    item.Id_usuario,
                    item.Usuario,
                    item.Correo,
                    item.Celular
                    );
            }
        }

        //Guardar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtCelular.Text, out long Celular) || txtCelular.Text.Count() < 10 || txtCelular.Text.Count() > 10)
            {
                txtCelular.Focus();
                MessageBox.Show("El campo Celular está vacío o no tiene un valor numérico entero de 10 dígitos");
                return;
            }

            if (txtContrasena.Text != txtRepetirContrasena.Text)
            {
                txtContrasena.Focus();
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            UsuariosModel modelo = new UsuariosModel();

            if (sender.ToString() == "System.Windows.Forms.Button, Text: Modificar")
            {
                if (int.TryParse(txtIdUsuario.Text, out int IdUsuario))
                {
                    if (IdUsuario > 0)
                    {
                        modelo.Id_usuario = IdUsuario;
                    }
                    else
                    {
                        txtIdUsuario.Focus();
                        MessageBox.Show("El campo ID_Usuario debe contener un número entero mayor a 0");
                        return;
                    }
                }
                else
                {
                    txtIdUsuario.Focus();
                    MessageBox.Show("El campo ID_Usuario está vacío o no tiene un valor numérico entero");
                    return;
                }
            }

            modelo.Usuario = txtUsuario.Text;
            modelo.Contrasena = txtContrasena.Text;
            modelo.Correo = txtCorreo.Text;
            modelo.Celular = Celular.ToString();

            data.Guardar(modelo);

            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtRepetirContrasena.Clear();
            txtCorreo.Clear();
            txtCelular.Clear();

            btnBuscar_Click(sender, e);
        }

        //ELiminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdUsuario.Text, out int id))
            {
                data.Eliminar(id);
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("El campo ID_Usuario está vacío o no tiene un valor numérico");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
