
namespace proyecto1
{
    partial class FormDevolucionescs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevolucionescs));
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            this.lblDevoluciones = new System.Windows.Forms.Label();
            this.cmbMotivoDevoluciones = new System.Windows.Forms.ComboBox();
            this.lblMotivoDevoluciones = new System.Windows.Forms.Label();
            this.txtDescripcionDevoluciones = new System.Windows.Forms.TextBox();
            this.lblDescripcionDevoluciones = new System.Windows.Forms.Label();
            this.txtFacturaDevoluciones = new System.Windows.Forms.TextBox();
            this.lblNFacturaDevoluciones = new System.Windows.Forms.Label();
            this.btnRealizarDevoluciones = new System.Windows.Forms.Button();
            this.btnCerrarDevoluciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(260, 219);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 66;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // lblDevoluciones
            // 
            this.lblDevoluciones.AutoSize = true;
            this.lblDevoluciones.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevoluciones.Location = new System.Drawing.Point(701, 13);
            this.lblDevoluciones.Name = "lblDevoluciones";
            this.lblDevoluciones.Size = new System.Drawing.Size(240, 49);
            this.lblDevoluciones.TabIndex = 67;
            this.lblDevoluciones.Text = "Devoluciones";
            // 
            // cmbMotivoDevoluciones
            // 
            this.cmbMotivoDevoluciones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivoDevoluciones.FormattingEnabled = true;
            this.cmbMotivoDevoluciones.Items.AddRange(new object[] {
            "Desperfectos",
            "Error de eleccion"});
            this.cmbMotivoDevoluciones.Location = new System.Drawing.Point(685, 206);
            this.cmbMotivoDevoluciones.Name = "cmbMotivoDevoluciones";
            this.cmbMotivoDevoluciones.Size = new System.Drawing.Size(177, 32);
            this.cmbMotivoDevoluciones.TabIndex = 91;
            // 
            // lblMotivoDevoluciones
            // 
            this.lblMotivoDevoluciones.AutoSize = true;
            this.lblMotivoDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoDevoluciones.Location = new System.Drawing.Point(607, 199);
            this.lblMotivoDevoluciones.Name = "lblMotivoDevoluciones";
            this.lblMotivoDevoluciones.Size = new System.Drawing.Size(86, 37);
            this.lblMotivoDevoluciones.TabIndex = 90;
            this.lblMotivoDevoluciones.Text = "Tipo: ";
            // 
            // txtDescripcionDevoluciones
            // 
            this.txtDescripcionDevoluciones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDevoluciones.Location = new System.Drawing.Point(685, 160);
            this.txtDescripcionDevoluciones.Name = "txtDescripcionDevoluciones";
            this.txtDescripcionDevoluciones.Size = new System.Drawing.Size(177, 32);
            this.txtDescripcionDevoluciones.TabIndex = 89;
            // 
            // lblDescripcionDevoluciones
            // 
            this.lblDescripcionDevoluciones.AutoSize = true;
            this.lblDescripcionDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDevoluciones.Location = new System.Drawing.Point(518, 157);
            this.lblDescripcionDevoluciones.Name = "lblDescripcionDevoluciones";
            this.lblDescripcionDevoluciones.Size = new System.Drawing.Size(175, 37);
            this.lblDescripcionDevoluciones.TabIndex = 88;
            this.lblDescripcionDevoluciones.Text = "Descripción: ";
            // 
            // txtFacturaDevoluciones
            // 
            this.txtFacturaDevoluciones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaDevoluciones.Location = new System.Drawing.Point(685, 122);
            this.txtFacturaDevoluciones.Name = "txtFacturaDevoluciones";
            this.txtFacturaDevoluciones.Size = new System.Drawing.Size(177, 32);
            this.txtFacturaDevoluciones.TabIndex = 93;
            // 
            // lblNFacturaDevoluciones
            // 
            this.lblNFacturaDevoluciones.AutoSize = true;
            this.lblNFacturaDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFacturaDevoluciones.Location = new System.Drawing.Point(536, 120);
            this.lblNFacturaDevoluciones.Name = "lblNFacturaDevoluciones";
            this.lblNFacturaDevoluciones.Size = new System.Drawing.Size(157, 37);
            this.lblNFacturaDevoluciones.TabIndex = 92;
            this.lblNFacturaDevoluciones.Text = "N° Factura: ";
            // 
            // btnRealizarDevoluciones
            // 
            this.btnRealizarDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarDevoluciones.Location = new System.Drawing.Point(580, 345);
            this.btnRealizarDevoluciones.Name = "btnRealizarDevoluciones";
            this.btnRealizarDevoluciones.Size = new System.Drawing.Size(363, 203);
            this.btnRealizarDevoluciones.TabIndex = 94;
            this.btnRealizarDevoluciones.Text = "Realizar\r\ndevolucion";
            this.btnRealizarDevoluciones.UseVisualStyleBackColor = true;
            this.btnRealizarDevoluciones.Click += new System.EventHandler(this.btnRealizarDevoluciones_Click);
            // 
            // btnCerrarDevoluciones
            // 
            this.btnCerrarDevoluciones.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDevoluciones.Location = new System.Drawing.Point(1361, 608);
            this.btnCerrarDevoluciones.Name = "btnCerrarDevoluciones";
            this.btnCerrarDevoluciones.Size = new System.Drawing.Size(156, 55);
            this.btnCerrarDevoluciones.TabIndex = 95;
            this.btnCerrarDevoluciones.Text = "Cerrar";
            this.btnCerrarDevoluciones.UseVisualStyleBackColor = true;
            this.btnCerrarDevoluciones.Click += new System.EventHandler(this.btnCerrarDevoluciones_Click);
            // 
            // FormDevolucionescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 675);
            this.Controls.Add(this.btnCerrarDevoluciones);
            this.Controls.Add(this.btnRealizarDevoluciones);
            this.Controls.Add(this.txtFacturaDevoluciones);
            this.Controls.Add(this.lblNFacturaDevoluciones);
            this.Controls.Add(this.cmbMotivoDevoluciones);
            this.Controls.Add(this.lblMotivoDevoluciones);
            this.Controls.Add(this.txtDescripcionDevoluciones);
            this.Controls.Add(this.lblDescripcionDevoluciones);
            this.Controls.Add(this.lblDevoluciones);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Name = "FormDevolucionescs";
            this.Text = "FormDevolucionescs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCuentas;
        private System.Windows.Forms.Label lblDevoluciones;
        private System.Windows.Forms.ComboBox cmbMotivoDevoluciones;
        private System.Windows.Forms.Label lblMotivoDevoluciones;
        private System.Windows.Forms.TextBox txtDescripcionDevoluciones;
        private System.Windows.Forms.Label lblDescripcionDevoluciones;
        private System.Windows.Forms.TextBox txtFacturaDevoluciones;
        private System.Windows.Forms.Label lblNFacturaDevoluciones;
        private System.Windows.Forms.Button btnRealizarDevoluciones;
        private System.Windows.Forms.Button btnCerrarDevoluciones;
    }
}