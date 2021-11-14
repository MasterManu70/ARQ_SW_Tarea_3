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
    public partial class FrmProductos : Form
    {
        ProductosController data = new ProductosController();
        List<ProductosModel> lista = new List<ProductosModel>();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.Columns.Add("Id_Producto", "ID Producto");
            dgvProductos.Columns.Add("Producto", "Producto");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Existencia", "Existencia");
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProducto.Text = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            nudExistencia.Value = int.Parse(dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString());
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

            dgvProductos.Rows.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron registros");
                return;
            }

            foreach (ProductosModel item in lista)
            {
                dgvProductos.Rows.Add(
                    item.Id_producto,
                    item.Producto,
                    item.Precio,
                    item.Existencia
                    );
            }
        }

        //Guardar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPrecio.Text, out double Precio))
            {
                txtPrecio.Focus();
                MessageBox.Show("El campo Precio está vacío o no tiene un valor numérico entero");
                return;
            }

            ProductosModel modelo = new ProductosModel();

            if (sender.ToString() == "System.Windows.Forms.Button, Text: Modificar")
            {
                if (int.TryParse(txtIdProducto.Text, out int IdProducto))
                {
                    if (IdProducto > 0)
                    {
                        modelo.Id_producto = IdProducto;
                    }
                    else
                    {
                        txtIdProducto.Focus();
                        MessageBox.Show("El campo ID_Producto debe contener un número entero mayor a 0");
                        return;
                    }
                }
                else
                {
                    txtIdProducto.Focus();
                    MessageBox.Show("El campo ID_Producto está vacío o no tiene un valor numérico entero");
                    return;
                }
            }

            modelo.Producto = txtProducto.Text;
            modelo.Precio = Precio;
            modelo.Existencia = int.Parse(nudExistencia.Value + "");

            data.Guardar(modelo);

            txtIdProducto.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            nudExistencia.Value = 1;

            btnBuscar_Click(sender, e);
        }

        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdProducto.Text, out int id))
            {
                data.Eliminar(id);
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("El campo ID_Producto está vacío o no tiene un valor numérico");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
