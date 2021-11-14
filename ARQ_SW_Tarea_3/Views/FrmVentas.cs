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
    public partial class FrmVentas : Form
    {
        VentasController data = new VentasController();
        List<VentasModel> lista = new List<VentasModel>();
        public FrmVentas()
        {
            InitializeComponent();
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.Columns.Add("Id_Venta", "ID Venta");
            dgvVentas.Columns.Add("Id_Cliente", "ID Cliente");
            dgvVentas.Columns.Add("Id_Producto", "ID Producto");
            dgvVentas.Columns.Add("FechaVenta", "Fecha Venta");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("PrecioVenta", "Precio Venta");
        }
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdVenta.Text = dgvVentas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIdCliente.Text = dgvVentas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdProducto.Text = dgvVentas.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpFechaVenta.Value = Convert.ToDateTime(dgvVentas.Rows[e.RowIndex].Cells[3].Value);
            nudCantidad.Value = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtPrecioVenta.Text = dgvVentas.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        //Consultar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar.Text,out int id) && txtBuscar.Text != String.Empty)
            {
                MessageBox.Show("Solo se permiten números enteros como parámetro de búsqueda");
                txtBuscar.Focus();
                return;
            }

            lista = data.Consultar(id);
            
            dgvVentas.Rows.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron registros");
                return;
            }

            foreach (VentasModel item in lista)
            {
                dgvVentas.Rows.Add(
                    item.Id_Venta,
                    item.Id_Cliente,
                    item.Id_Producto,
                    item.FechaVenta,
                    item.Cantidad,
                    item.PrecioVenta
                    );
            }
        }

        //Guardar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtIdCliente.Text, out int IdCliente))
            {
                txtIdCliente.Focus();
                MessageBox.Show("El campo ID_Cliente está vacío o no tiene un valor numérico entero");
                return;
            }

            if (!Int32.TryParse(txtIdProducto.Text, out int IdProducto))
            {
                txtIdProducto.Focus();
                MessageBox.Show("El campo ID_Producto está vacío o no tiene un valor numérico entero");
                return;
            }

            if (!Double.TryParse(txtPrecioVenta.Text, out double PrecioVenta))
            {
                txtIdProducto.Focus();
                MessageBox.Show("El campo ID_Producto está vacío o no tiene un valor numérico");
                return;
            }

            VentasModel modelo = new VentasModel();

            if (sender.ToString() == "System.Windows.Forms.Button, Text: Modificar")
            {
                if (int.TryParse(txtIdVenta.Text, out int IdVenta))
                {
                    if (IdVenta > 0)
                    {
                        modelo.Id_Venta = IdVenta;
                    }
                    else
                    {
                        txtIdVenta.Focus();
                        MessageBox.Show("El campo ID_Venta debe contener un número entero mayor a 0");
                        return;
                    }
                }
                else
                {
                    txtIdProducto.Focus();
                    MessageBox.Show("El campo ID_Venta está vacío o no tiene un valor numérico entero");
                    return;
                }
            }

            modelo.Id_Cliente = IdCliente;
            modelo.Id_Producto = IdProducto;
            modelo.FechaVenta = dtpFechaVenta.Value;
            modelo.Cantidad = int.Parse(nudCantidad.Value + "");
            modelo.PrecioVenta = PrecioVenta;

            data.Guardar(modelo);

            txtIdVenta.Clear();
            txtIdCliente.Clear();
            txtIdProducto.Clear();
            nudCantidad.Value = 1;
            txtPrecioVenta.Clear();
            dtpFechaVenta.Value = DateTime.Now;

            btnBuscar_Click(sender, e);
        }

        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdVenta.Text, out int id))
            {
                data.Eliminar(id);
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("El campo ID_Venta está vacío o no tiene un valor numérico");
        }

        //Limpiar campos para datos
        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtIdVenta.Clear();
            txtIdCliente.Clear();
            txtIdProducto.Clear();
            txtPrecioVenta.Clear();
            nudCantidad.Value = 1;
            dtpFechaVenta.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
