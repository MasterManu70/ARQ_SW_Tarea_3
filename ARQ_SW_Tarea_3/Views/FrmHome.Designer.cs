
namespace ARQ_SW_Tarea_3
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ArchivoToolStripDropDownButton,
            this.ReportesToolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "HomeToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ArchivoToolStripDropDownButton
            // 
            this.ArchivoToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ArchivoToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ArchivoToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ArchivoToolStripDropDownButton.Image")));
            this.ArchivoToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArchivoToolStripDropDownButton.Name = "ArchivoToolStripDropDownButton";
            this.ArchivoToolStripDropDownButton.ShowDropDownArrow = false;
            this.ArchivoToolStripDropDownButton.Size = new System.Drawing.Size(52, 22);
            this.ArchivoToolStripDropDownButton.Text = "Archivo";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ReportesToolStripDropDownButton
            // 
            this.ReportesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReportesToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem,
            this.reporteDeProductosToolStripMenuItem,
            this.reporteDeUsuariosToolStripMenuItem});
            this.ReportesToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportesToolStripDropDownButton.Image")));
            this.ReportesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportesToolStripDropDownButton.Name = "ReportesToolStripDropDownButton";
            this.ReportesToolStripDropDownButton.ShowDropDownArrow = false;
            this.ReportesToolStripDropDownButton.Size = new System.Drawing.Size(57, 22);
            this.ReportesToolStripDropDownButton.Text = "Reportes";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            this.reporteDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductosToolStripMenuItem_Click);
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            this.reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            this.reporteDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeUsuariosToolStripMenuItem.Text = "Reporte de Usuarios";
            this.reporteDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClientesToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ArchivoToolStripDropDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton ReportesToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
    }
}

