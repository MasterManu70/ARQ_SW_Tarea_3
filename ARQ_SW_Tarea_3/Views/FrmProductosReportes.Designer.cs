
namespace ARQ_SW_Tarea_3.Views
{
    partial class FrmProductosReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webProductos = new System.Windows.Forms.WebBrowser();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnChrome = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webProductos
            // 
            this.webProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webProductos.Location = new System.Drawing.Point(12, 41);
            this.webProductos.MinimumSize = new System.Drawing.Size(20, 20);
            this.webProductos.Name = "webProductos";
            this.webProductos.Size = new System.Drawing.Size(760, 508);
            this.webProductos.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(697, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnChrome
            // 
            this.btnChrome.Location = new System.Drawing.Point(174, 12);
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.Size = new System.Drawing.Size(75, 23);
            this.btnChrome.TabIndex = 3;
            this.btnChrome.Text = "Chrome";
            this.btnChrome.UseVisualStyleBackColor = true;
            this.btnChrome.Click += new System.EventHandler(this.btnChrome_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(93, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FrmProductosReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.webProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnChrome);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnGenerar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmProductosReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnChrome;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnGenerar;
    }
}