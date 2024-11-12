
namespace proyecto1
{
    partial class FormFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturacion));
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarFacturacion = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.txtNombreFacturacion = new System.Windows.Forms.TextBox();
            this.txtCantidadFacturacion = new System.Windows.Forms.TextBox();
            this.txtCodigoFacturacion = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.txtPrecioFacturacion = new System.Windows.Forms.TextBox();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgvFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFacturacion.ColumnHeadersHeight = 29;
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigo,
            this.ColumnaNombre,
            this.ColumnaCantidad,
            this.ColumnaPrecioUnidad,
            this.ColumnaTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFacturacion.EnableHeadersVisualStyles = false;
            this.dgvFacturacion.GridColor = System.Drawing.Color.Black;
            this.dgvFacturacion.Location = new System.Drawing.Point(95, 320);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvFacturacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFacturacion.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFacturacion.Size = new System.Drawing.Size(697, 150);
            this.dgvFacturacion.TabIndex = 80;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaCodigo.HeaderText = "N° factura";
            this.ColumnaCodigo.MinimumWidth = 6;
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.Width = 104;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.MinimumWidth = 6;
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.Width = 210;
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.MinimumWidth = 6;
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.Width = 96;
            // 
            // ColumnaPrecioUnidad
            // 
            this.ColumnaPrecioUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaPrecioUnidad.HeaderText = "Precio-Unidad ";
            this.ColumnaPrecioUnidad.MinimumWidth = 6;
            this.ColumnaPrecioUnidad.Name = "ColumnaPrecioUnidad";
            this.ColumnaPrecioUnidad.Width = 137;
            // 
            // ColumnaTotal
            // 
            this.ColumnaTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaTotal.HeaderText = "Total";
            this.ColumnaTotal.MinimumWidth = 6;
            this.ColumnaTotal.Name = "ColumnaTotal";
            this.ColumnaTotal.Width = 68;
            // 
            // btnCerrarFacturacion
            // 
            this.btnCerrarFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCerrarFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarFacturacion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrarFacturacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarFacturacion.Location = new System.Drawing.Point(677, 476);
            this.btnCerrarFacturacion.Name = "btnCerrarFacturacion";
            this.btnCerrarFacturacion.Size = new System.Drawing.Size(137, 43);
            this.btnCerrarFacturacion.TabIndex = 79;
            this.btnCerrarFacturacion.Text = "Cerrar";
            this.btnCerrarFacturacion.UseVisualStyleBackColor = false;
            this.btnCerrarFacturacion.Click += new System.EventHandler(this.btnCerrarFacturacion_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSiguiente.Location = new System.Drawing.Point(500, 476);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(110, 43);
            this.btnSiguiente.TabIndex = 78;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnterior.Location = new System.Drawing.Point(256, 476);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(110, 43);
            this.btnAnterior.TabIndex = 77;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturacion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.Location = new System.Drawing.Point(38, 476);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(83, 43);
            this.btnFacturacion.TabIndex = 76;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearFactura.Location = new System.Drawing.Point(391, 271);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(150, 43);
            this.btnCrearFactura.TabIndex = 74;
            this.btnCrearFactura.Text = "Crear";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtNombreFacturacion
            // 
            this.txtNombreFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtNombreFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreFacturacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFacturacion.Location = new System.Drawing.Point(372, 116);
            this.txtNombreFacturacion.Name = "txtNombreFacturacion";
            this.txtNombreFacturacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNombreFacturacion.Size = new System.Drawing.Size(189, 27);
            this.txtNombreFacturacion.TabIndex = 73;
            this.txtNombreFacturacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantidadFacturacion
            // 
            this.txtCantidadFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtCantidadFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadFacturacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadFacturacion.Location = new System.Drawing.Point(372, 153);
            this.txtCantidadFacturacion.Name = "txtCantidadFacturacion";
            this.txtCantidadFacturacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCantidadFacturacion.Size = new System.Drawing.Size(189, 27);
            this.txtCantidadFacturacion.TabIndex = 72;
            this.txtCantidadFacturacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigoFacturacion
            // 
            this.txtCodigoFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtCodigoFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoFacturacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFacturacion.Location = new System.Drawing.Point(372, 80);
            this.txtCodigoFacturacion.Name = "txtCodigoFacturacion";
            this.txtCodigoFacturacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCodigoFacturacion.Size = new System.Drawing.Size(189, 27);
            this.txtCodigoFacturacion.TabIndex = 71;
            this.txtCodigoFacturacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(272, 153);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(94, 26);
            this.lblCantidad.TabIndex = 70;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigo.Location = new System.Drawing.Point(275, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 26);
            this.lblCodigo.TabIndex = 69;
            this.lblCodigo.Text = "Numero: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(227, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 26);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Medicamento: ";
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFacturacion.Location = new System.Drawing.Point(365, 21);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(196, 45);
            this.lblFacturacion.TabIndex = 67;
            this.lblFacturacion.Text = "Facturación";
            this.lblFacturacion.Click += new System.EventHandler(this.lblFacturacion_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(38, 51);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(175, 156);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 66;
            this.PicLogo.TabStop = false;
            // 
            // txtPrecioFacturacion
            // 
            this.txtPrecioFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtPrecioFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioFacturacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioFacturacion.Location = new System.Drawing.Point(372, 186);
            this.txtPrecioFacturacion.Name = "txtPrecioFacturacion";
            this.txtPrecioFacturacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrecioFacturacion.Size = new System.Drawing.Size(189, 27);
            this.txtPrecioFacturacion.TabIndex = 82;
            this.txtPrecioFacturacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtTotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFactura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFactura.Location = new System.Drawing.Point(373, 219);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTotalFactura.Size = new System.Drawing.Size(189, 27);
            this.txtTotalFactura.TabIndex = 83;
            this.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPrecioUnidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioUnidad.Location = new System.Drawing.Point(227, 186);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(139, 26);
            this.lblPrecioUnidad.TabIndex = 84;
            this.lblPrecioUnidad.Text = "Precio Unidad:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(307, 220);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 26);
            this.lblTotal.TabIndex = 85;
            this.lblTotal.Text = "Total:";
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(850, 531);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecioUnidad);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.txtPrecioFacturacion);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.btnCerrarFacturacion);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.txtNombreFacturacion);
            this.Controls.Add(this.txtCantidadFacturacion);
            this.Controls.Add(this.txtCodigoFacturacion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.PicLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Facturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.Button btnCerrarFacturacion;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.TextBox txtNombreFacturacion;
        private System.Windows.Forms.TextBox txtCantidadFacturacion;
        private System.Windows.Forms.TextBox txtCodigoFacturacion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TextBox txtPrecioFacturacion;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTotal;
    }
}