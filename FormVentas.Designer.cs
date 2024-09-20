
namespace proyecto1
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVentas = new System.Windows.Forms.Label();
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            this.txtCodigoVentas = new System.Windows.Forms.TextBox();
            this.txtCantidadVentas = new System.Windows.Forms.TextBox();
            this.txtClienteVenta = new System.Windows.Forms.TextBox();
            this.txtMedicamentoVentas = new System.Windows.Forms.TextBox();
            this.lblCodigoVentas = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblClienteVentas = new System.Windows.Forms.Label();
            this.lblMedicamentoVentas = new System.Windows.Forms.Label();
            this.cmbTipoVentas = new System.Windows.Forms.ComboBox();
            this.lblTipoVentas = new System.Windows.Forms.Label();
            this.btnAgregarVentas = new System.Windows.Forms.Button();
            this.dgbventas = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarVentas = new System.Windows.Forms.Button();
            this.txtCambioVentas = new System.Windows.Forms.TextBox();
            this.lblCambioVentas = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarVentas = new System.Windows.Forms.Button();
            this.txtRecibidoVentas = new System.Windows.Forms.TextBox();
            this.lblRecibidoVentas = new System.Windows.Forms.Label();
            this.btnRealizarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbventas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(729, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(132, 49);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(260, 219);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 65;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // txtCodigoVentas
            // 
            this.txtCodigoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVentas.Location = new System.Drawing.Point(605, 158);
            this.txtCodigoVentas.Name = "txtCodigoVentas";
            this.txtCodigoVentas.Size = new System.Drawing.Size(177, 32);
            this.txtCodigoVentas.TabIndex = 85;
            // 
            // txtCantidadVentas
            // 
            this.txtCantidadVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadVentas.Location = new System.Drawing.Point(605, 200);
            this.txtCantidadVentas.Name = "txtCantidadVentas";
            this.txtCantidadVentas.Size = new System.Drawing.Size(177, 32);
            this.txtCantidadVentas.TabIndex = 84;
            // 
            // txtClienteVenta
            // 
            this.txtClienteVenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteVenta.Location = new System.Drawing.Point(605, 78);
            this.txtClienteVenta.Name = "txtClienteVenta";
            this.txtClienteVenta.Size = new System.Drawing.Size(177, 32);
            this.txtClienteVenta.TabIndex = 83;
            this.txtClienteVenta.Text = "Cliente";
            // 
            // txtMedicamentoVentas
            // 
            this.txtMedicamentoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamentoVentas.Location = new System.Drawing.Point(605, 116);
            this.txtMedicamentoVentas.Name = "txtMedicamentoVentas";
            this.txtMedicamentoVentas.Size = new System.Drawing.Size(177, 32);
            this.txtMedicamentoVentas.TabIndex = 82;
            // 
            // lblCodigoVentas
            // 
            this.lblCodigoVentas.AutoSize = true;
            this.lblCodigoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVentas.Location = new System.Drawing.Point(492, 151);
            this.lblCodigoVentas.Name = "lblCodigoVentas";
            this.lblCodigoVentas.Size = new System.Drawing.Size(117, 37);
            this.lblCodigoVentas.TabIndex = 81;
            this.lblCodigoVentas.Text = "Código: ";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(468, 193);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(141, 37);
            this.lblCantidadVentas.TabIndex = 80;
            this.lblCantidadVentas.Text = "Cantidad: ";
            // 
            // lblClienteVentas
            // 
            this.lblClienteVentas.AutoSize = true;
            this.lblClienteVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteVentas.Location = new System.Drawing.Point(491, 71);
            this.lblClienteVentas.Name = "lblClienteVentas";
            this.lblClienteVentas.Size = new System.Drawing.Size(118, 37);
            this.lblClienteVentas.TabIndex = 79;
            this.lblClienteVentas.Text = "Cliente: ";
            // 
            // lblMedicamentoVentas
            // 
            this.lblMedicamentoVentas.AutoSize = true;
            this.lblMedicamentoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamentoVentas.Location = new System.Drawing.Point(405, 111);
            this.lblMedicamentoVentas.Name = "lblMedicamentoVentas";
            this.lblMedicamentoVentas.Size = new System.Drawing.Size(204, 37);
            this.lblMedicamentoVentas.TabIndex = 78;
            this.lblMedicamentoVentas.Text = "Medicamento: ";
            // 
            // cmbTipoVentas
            // 
            this.cmbTipoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVentas.FormattingEnabled = true;
            this.cmbTipoVentas.Items.AddRange(new object[] {
            "Pastillas",
            "botes",
            "cajas"});
            this.cmbTipoVentas.Location = new System.Drawing.Point(605, 247);
            this.cmbTipoVentas.Name = "cmbTipoVentas";
            this.cmbTipoVentas.Size = new System.Drawing.Size(177, 32);
            this.cmbTipoVentas.TabIndex = 87;
            // 
            // lblTipoVentas
            // 
            this.lblTipoVentas.AutoSize = true;
            this.lblTipoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVentas.Location = new System.Drawing.Point(523, 242);
            this.lblTipoVentas.Name = "lblTipoVentas";
            this.lblTipoVentas.Size = new System.Drawing.Size(86, 37);
            this.lblTipoVentas.TabIndex = 86;
            this.lblTipoVentas.Text = "Tipo: ";
            // 
            // btnAgregarVentas
            // 
            this.btnAgregarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVentas.Location = new System.Drawing.Point(675, 314);
            this.btnAgregarVentas.Name = "btnAgregarVentas";
            this.btnAgregarVentas.Size = new System.Drawing.Size(136, 46);
            this.btnAgregarVentas.TabIndex = 89;
            this.btnAgregarVentas.Text = "Agregar";
            this.btnAgregarVentas.UseVisualStyleBackColor = true;
            this.btnAgregarVentas.Click += new System.EventHandler(this.btnAgregarVentas_Click);
            // 
            // dgbventas
            // 
            this.dgbventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgbventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgbventas.ColumnHeadersHeight = 29;
            this.dgbventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigo,
            this.ColumnaNombre,
            this.ColumnaCantidad,
            this.ColumnaPrecio,
            this.ColumnaPDescuento,
            this.ColumnaTotal});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbventas.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgbventas.Enabled = false;
            this.dgbventas.EnableHeadersVisualStyles = false;
            this.dgbventas.GridColor = System.Drawing.Color.Black;
            this.dgbventas.Location = new System.Drawing.Point(13, 375);
            this.dgbventas.Margin = new System.Windows.Forms.Padding(4);
            this.dgbventas.Name = "dgbventas";
            this.dgbventas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgbventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dgbventas.RowHeadersWidth = 51;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgbventas.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.dgbventas.Size = new System.Drawing.Size(1528, 231);
            this.dgbventas.TabIndex = 90;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Código";
            this.ColumnaCodigo.MinimumWidth = 6;
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.Width = 210;
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
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.MinimumWidth = 6;
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.Width = 210;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.MinimumWidth = 6;
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            this.ColumnaPrecio.Width = 125;
            // 
            // ColumnaPDescuento
            // 
            this.ColumnaPDescuento.HeaderText = "P.Descuento";
            this.ColumnaPDescuento.MinimumWidth = 6;
            this.ColumnaPDescuento.Name = "ColumnaPDescuento";
            this.ColumnaPDescuento.Width = 125;
            // 
            // ColumnaTotal
            // 
            this.ColumnaTotal.HeaderText = "total";
            this.ColumnaTotal.MinimumWidth = 6;
            this.ColumnaTotal.Name = "ColumnaTotal";
            this.ColumnaTotal.Width = 125;
            // 
            // btnCancelarVentas
            // 
            this.btnCancelarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVentas.Location = new System.Drawing.Point(91, 617);
            this.btnCancelarVentas.Name = "btnCancelarVentas";
            this.btnCancelarVentas.Size = new System.Drawing.Size(149, 56);
            this.btnCancelarVentas.TabIndex = 91;
            this.btnCancelarVentas.Text = "Cancelar";
            this.btnCancelarVentas.UseVisualStyleBackColor = true;
            this.btnCancelarVentas.Click += new System.EventHandler(this.btnCancelarVentas_Click);
            // 
            // txtCambioVentas
            // 
            this.txtCambioVentas.Enabled = false;
            this.txtCambioVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioVentas.Location = new System.Drawing.Point(538, 631);
            this.txtCambioVentas.Name = "txtCambioVentas";
            this.txtCambioVentas.Size = new System.Drawing.Size(73, 32);
            this.txtCambioVentas.TabIndex = 93;
            this.txtCambioVentas.Text = "$ 0.00";
            // 
            // lblCambioVentas
            // 
            this.lblCambioVentas.AutoSize = true;
            this.lblCambioVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioVentas.Location = new System.Drawing.Point(425, 624);
            this.lblCambioVentas.Name = "lblCambioVentas";
            this.lblCambioVentas.Size = new System.Drawing.Size(110, 37);
            this.lblCambioVentas.TabIndex = 92;
            this.lblCambioVentas.Text = "Cambio";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Enabled = false;
            this.txtTotalVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.Location = new System.Drawing.Point(920, 615);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(71, 32);
            this.txtTotalVentas.TabIndex = 95;
            this.txtTotalVentas.Text = "3323";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 94;
            this.label1.Text = "Total: ";
            // 
            // btnCerrarVentas
            // 
            this.btnCerrarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVentas.Location = new System.Drawing.Point(1392, 613);
            this.btnCerrarVentas.Name = "btnCerrarVentas";
            this.btnCerrarVentas.Size = new System.Drawing.Size(149, 56);
            this.btnCerrarVentas.TabIndex = 96;
            this.btnCerrarVentas.Text = "Cerrar";
            this.btnCerrarVentas.UseVisualStyleBackColor = true;
            this.btnCerrarVentas.Click += new System.EventHandler(this.btnCerrarVentas_Click);
            // 
            // txtRecibidoVentas
            // 
            this.txtRecibidoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibidoVentas.Location = new System.Drawing.Point(945, 126);
            this.txtRecibidoVentas.Name = "txtRecibidoVentas";
            this.txtRecibidoVentas.Size = new System.Drawing.Size(177, 32);
            this.txtRecibidoVentas.TabIndex = 98;
            // 
            // lblRecibidoVentas
            // 
            this.lblRecibidoVentas.AutoSize = true;
            this.lblRecibidoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibidoVentas.Location = new System.Drawing.Point(966, 86);
            this.lblRecibidoVentas.Name = "lblRecibidoVentas";
            this.lblRecibidoVentas.Size = new System.Drawing.Size(122, 37);
            this.lblRecibidoVentas.TabIndex = 97;
            this.lblRecibidoVentas.Text = "Recibido";
            // 
            // btnRealizarVentas
            // 
            this.btnRealizarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVentas.Location = new System.Drawing.Point(973, 173);
            this.btnRealizarVentas.Name = "btnRealizarVentas";
            this.btnRealizarVentas.Size = new System.Drawing.Size(136, 46);
            this.btnRealizarVentas.TabIndex = 99;
            this.btnRealizarVentas.Text = "Realizar";
            this.btnRealizarVentas.UseVisualStyleBackColor = true;
            this.btnRealizarVentas.Click += new System.EventHandler(this.btnRealizarVentas_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 675);
            this.Controls.Add(this.btnRealizarVentas);
            this.Controls.Add(this.txtRecibidoVentas);
            this.Controls.Add(this.lblRecibidoVentas);
            this.Controls.Add(this.btnCerrarVentas);
            this.Controls.Add(this.txtTotalVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCambioVentas);
            this.Controls.Add(this.lblCambioVentas);
            this.Controls.Add(this.btnCancelarVentas);
            this.Controls.Add(this.dgbventas);
            this.Controls.Add(this.btnAgregarVentas);
            this.Controls.Add(this.cmbTipoVentas);
            this.Controls.Add(this.lblTipoVentas);
            this.Controls.Add(this.txtCodigoVentas);
            this.Controls.Add(this.txtCantidadVentas);
            this.Controls.Add(this.txtClienteVenta);
            this.Controls.Add(this.txtMedicamentoVentas);
            this.Controls.Add(this.lblCodigoVentas);
            this.Controls.Add(this.lblCantidadVentas);
            this.Controls.Add(this.lblClienteVentas);
            this.Controls.Add(this.lblMedicamentoVentas);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Controls.Add(this.lblVentas);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.PictureBox pictureBoxCuentas;
        private System.Windows.Forms.TextBox txtCodigoVentas;
        private System.Windows.Forms.TextBox txtCantidadVentas;
        private System.Windows.Forms.TextBox txtClienteVenta;
        private System.Windows.Forms.TextBox txtMedicamentoVentas;
        private System.Windows.Forms.Label lblCodigoVentas;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label lblClienteVentas;
        private System.Windows.Forms.Label lblMedicamentoVentas;
        private System.Windows.Forms.ComboBox cmbTipoVentas;
        private System.Windows.Forms.Label lblTipoVentas;
        private System.Windows.Forms.Button btnAgregarVentas;
        private System.Windows.Forms.DataGridView dgbventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTotal;
        private System.Windows.Forms.Button btnCancelarVentas;
        private System.Windows.Forms.TextBox txtCambioVentas;
        private System.Windows.Forms.Label lblCambioVentas;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarVentas;
        private System.Windows.Forms.TextBox txtRecibidoVentas;
        private System.Windows.Forms.Label lblRecibidoVentas;
        private System.Windows.Forms.Button btnRealizarVentas;
    }
}