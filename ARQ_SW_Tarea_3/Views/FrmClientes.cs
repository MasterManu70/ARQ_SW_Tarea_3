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
    public partial class FrmClientes : Form
    {
        ClientesController data = new ClientesController();
        List<ClientesModel> lista = new List<ClientesModel>();
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Columns.Add("Id_Cliente", "ID Cliente");
            dgvClientes.Columns.Add("Cliente", "Cliente");
            dgvClientes.Columns.Add("Domicilio", "Domicilio");
            dgvClientes.Columns.Add("Celular", "Celular");
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCliente.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCliente.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDomicilio.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
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

            foreach (ClientesModel item in lista)
            {
                dgvClientes.Rows.Add(
                    item.Id_cliente,
                    item.Cliente,
                    item.Domicilio,
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

            ClientesModel modelo = new ClientesModel();

            if (sender.ToString() == "System.Windows.Forms.Button, Text: Modificar")
            {
                if (int.TryParse(txtIdCliente.Text, out int IdCliente))
                {
                    if (IdCliente > 0)
                    {
                        modelo.Id_cliente = IdCliente;
                    }
                    else
                    {
                        txtIdCliente.Focus();
                        MessageBox.Show("El campo ID_Cliente debe contener un número entero mayor a 0");
                        return;
                    }
                }
                else
                {
                    txtIdCliente.Focus();
                    MessageBox.Show("El campo ID_Cliente está vacío o no tiene un valor numérico entero");
                    return;
                }
            }

            modelo.Cliente = txtCliente.Text;
            modelo.Domicilio = txtDomicilio.Text;
            modelo.Celular = Celular.ToString();

            data.Guardar(modelo);

            txtIdCliente.Clear();
            txtCliente.Clear();
            txtDomicilio.Clear();
            txtCelular.Clear();

            btnBuscar_Click(sender, e);
        }

        //ELiminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdCliente.Text, out int id))
            {
                data.Eliminar(id);
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("El campo ID_Venta está vacío o no tiene un valor numérico");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
