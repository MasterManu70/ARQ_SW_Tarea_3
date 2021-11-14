using ARQ_SW_Tarea_3.Controllers;
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
    public partial class FrmProductosReportes : Form
    {
        ProductosReportesController data = new ProductosReportesController();
        string archivo;
        public FrmProductosReportes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            archivo = data.Reporte();
            Uri dir = new Uri(archivo);
            webProductos.Url = dir;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel", "\"" + archivo + "\"");
        }

        private void btnChrome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome", "\"" + archivo + "\"");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
