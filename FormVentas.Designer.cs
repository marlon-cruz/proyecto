
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarVentas = new System.Windows.Forms.Button();
            this.txtCambioVentas = new System.Windows.Forms.TextBox();
            this.lblCambioVentas = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCerrarVentas = new System.Windows.Forms.Button();
            this.txtRecibidoVentas = new System.Windows.Forms.TextBox();
            this.lblRecibidoVentas = new System.Windows.Forms.Label();
            this.btnRealizarVentas = new System.Windows.Forms.Button();
            this.btnEditarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblVentas.Location = new System.Drawing.Point(547, 7);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(107, 39);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(195, 178);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 65;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // txtCodigoVentas
            // 
            this.txtCodigoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodigoVentas.Location = new System.Drawing.Point(454, 128);
            this.txtCodigoVentas.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoVentas.Name = "txtCodigoVentas";
            this.txtCodigoVentas.Size = new System.Drawing.Size(134, 27);
            this.txtCodigoVentas.TabIndex = 85;
            this.txtCodigoVentas.TextChanged += new System.EventHandler(this.txtCodigoVentas_TextChanged);
            // 
            // txtCantidadVentas
            // 
            this.txtCantidadVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCantidadVentas.Location = new System.Drawing.Point(454, 162);
            this.txtCantidadVentas.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadVentas.Name = "txtCantidadVentas";
            this.txtCantidadVentas.Size = new System.Drawing.Size(134, 27);
            this.txtCantidadVentas.TabIndex = 84;
            // 
            // txtClienteVenta
            // 
            this.txtClienteVenta.BackColor = System.Drawing.Color.Lavender;
            this.txtClienteVenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteVenta.Location = new System.Drawing.Point(454, 60);
            this.txtClienteVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteVenta.Name = "txtClienteVenta";
            this.txtClienteVenta.Size = new System.Drawing.Size(134, 27);
            this.txtClienteVenta.TabIndex = 83;
            this.txtClienteVenta.TextChanged += new System.EventHandler(this.txtClienteVenta_TextChanged);
            // 
            // txtMedicamentoVentas
            // 
            this.txtMedicamentoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtMedicamentoVentas.Location = new System.Drawing.Point(454, 94);
            this.txtMedicamentoVentas.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedicamentoVentas.Name = "txtMedicamentoVentas";
            this.txtMedicamentoVentas.Size = new System.Drawing.Size(134, 27);
            this.txtMedicamentoVentas.TabIndex = 82;
            // 
            // lblCodigoVentas
            // 
            this.lblCodigoVentas.AutoSize = true;
            this.lblCodigoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblCodigoVentas.Location = new System.Drawing.Point(351, 123);
            this.lblCodigoVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoVentas.Name = "lblCodigoVentas";
            this.lblCodigoVentas.Size = new System.Drawing.Size(94, 29);
            this.lblCodigoVentas.TabIndex = 81;
            this.lblCodigoVentas.Text = "Código: ";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantidadVentas.Location = new System.Drawing.Point(331, 162);
            this.lblCantidadVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(115, 29);
            this.lblCantidadVentas.TabIndex = 80;
            this.lblCantidadVentas.Text = "Cantidad: ";
            // 
            // lblClienteVentas
            // 
            this.lblClienteVentas.AutoSize = true;
            this.lblClienteVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteVentas.Location = new System.Drawing.Point(351, 58);
            this.lblClienteVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteVentas.Name = "lblClienteVentas";
            this.lblClienteVentas.Size = new System.Drawing.Size(95, 29);
            this.lblClienteVentas.TabIndex = 79;
            this.lblClienteVentas.Text = "Cliente: ";
            this.lblClienteVentas.Click += new System.EventHandler(this.lblClienteVentas_Click);
            // 
            // lblMedicamentoVentas
            // 
            this.lblMedicamentoVentas.AutoSize = true;
            this.lblMedicamentoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblMedicamentoVentas.Location = new System.Drawing.Point(281, 89);
            this.lblMedicamentoVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicamentoVentas.Name = "lblMedicamentoVentas";
            this.lblMedicamentoVentas.Size = new System.Drawing.Size(165, 29);
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
            this.cmbTipoVentas.Location = new System.Drawing.Point(454, 201);
            this.cmbTipoVentas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoVentas.Name = "cmbTipoVentas";
            this.cmbTipoVentas.Size = new System.Drawing.Size(134, 27);
            this.cmbTipoVentas.TabIndex = 87;
            // 
            // lblTipoVentas
            // 
            this.lblTipoVentas.AutoSize = true;
            this.lblTipoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTipoVentas.Location = new System.Drawing.Point(376, 201);
            this.lblTipoVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoVentas.Name = "lblTipoVentas";
            this.lblTipoVentas.Size = new System.Drawing.Size(69, 29);
            this.lblTipoVentas.TabIndex = 86;
            this.lblTipoVentas.Text = "Tipo: ";
            // 
            // btnAgregarVentas
            // 
            this.btnAgregarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarVentas.Location = new System.Drawing.Point(474, 243);
            this.btnAgregarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarVentas.Name = "btnAgregarVentas";
            this.btnAgregarVentas.Size = new System.Drawing.Size(102, 37);
            this.btnAgregarVentas.TabIndex = 89;
            this.btnAgregarVentas.Text = "Agregar";
            this.btnAgregarVentas.UseVisualStyleBackColor = true;
            this.btnAgregarVentas.Click += new System.EventHandler(this.btnAgregarVentas_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeight = 29;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigo,
            this.ColumnaMedicamento,
            this.ColumnaCantidad,
            this.ColumnaPrecio,
            this.ColumnaPDescuento,
            this.ColumnaTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.Enabled = false;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.Black;
            this.dgvVentas.Location = new System.Drawing.Point(10, 295);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.Size = new System.Drawing.Size(1146, 188);
            this.dgvVentas.TabIndex = 90;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Código";
            this.ColumnaCodigo.MinimumWidth = 6;
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.Width = 210;
            // 
            // ColumnaMedicamento
            // 
            this.ColumnaMedicamento.HeaderText = "Medicamento";
            this.ColumnaMedicamento.MinimumWidth = 6;
            this.ColumnaMedicamento.Name = "ColumnaMedicamento";
            this.ColumnaMedicamento.Width = 210;
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
            this.ColumnaPDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaPDescuento.HeaderText = "Precio Descuento";
            this.ColumnaPDescuento.MinimumWidth = 6;
            this.ColumnaPDescuento.Name = "ColumnaPDescuento";
            this.ColumnaPDescuento.Width = 158;
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
            this.btnCancelarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelarVentas.Location = new System.Drawing.Point(68, 488);
            this.btnCancelarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarVentas.Name = "btnCancelarVentas";
            this.btnCancelarVentas.Size = new System.Drawing.Size(112, 46);
            this.btnCancelarVentas.TabIndex = 91;
            this.btnCancelarVentas.Text = "Cancelar";
            this.btnCancelarVentas.UseVisualStyleBackColor = true;
            this.btnCancelarVentas.Click += new System.EventHandler(this.btnCancelarVentas_Click);
            // 
            // txtCambioVentas
            // 
            this.txtCambioVentas.Enabled = false;
            this.txtCambioVentas.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioVentas.Location = new System.Drawing.Point(419, 497);
            this.txtCambioVentas.Margin = new System.Windows.Forms.Padding(2);
            this.txtCambioVentas.Name = "txtCambioVentas";
            this.txtCambioVentas.Size = new System.Drawing.Size(56, 30);
            this.txtCambioVentas.TabIndex = 93;
            this.txtCambioVentas.Text = "$ 0.00";
            // 
            // lblCambioVentas
            // 
            this.lblCambioVentas.AutoSize = true;
            this.lblCambioVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblCambioVentas.Location = new System.Drawing.Point(325, 498);
            this.lblCambioVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCambioVentas.Name = "lblCambioVentas";
            this.lblCambioVentas.Size = new System.Drawing.Size(90, 29);
            this.lblCambioVentas.TabIndex = 92;
            this.lblCambioVentas.Text = "Cambio";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Enabled = false;
            this.txtTotalVentas.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.Location = new System.Drawing.Point(695, 498);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(54, 30);
            this.txtTotalVentas.TabIndex = 95;
            this.txtTotalVentas.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(617, 498);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 29);
            this.lblTotal.TabIndex = 94;
            this.lblTotal.Text = "Total: ";
            // 
            // btnCerrarVentas
            // 
            this.btnCerrarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVentas.Location = new System.Drawing.Point(1044, 489);
            this.btnCerrarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarVentas.Name = "btnCerrarVentas";
            this.btnCerrarVentas.Size = new System.Drawing.Size(112, 46);
            this.btnCerrarVentas.TabIndex = 96;
            this.btnCerrarVentas.Text = "Cerrar";
            this.btnCerrarVentas.UseVisualStyleBackColor = true;
            this.btnCerrarVentas.Click += new System.EventHandler(this.btnCerrarVentas_Click);
            // 
            // txtRecibidoVentas
            // 
            this.txtRecibidoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtRecibidoVentas.Location = new System.Drawing.Point(709, 102);
            this.txtRecibidoVentas.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecibidoVentas.Name = "txtRecibidoVentas";
            this.txtRecibidoVentas.Size = new System.Drawing.Size(134, 27);
            this.txtRecibidoVentas.TabIndex = 98;
            // 
            // lblRecibidoVentas
            // 
            this.lblRecibidoVentas.AutoSize = true;
            this.lblRecibidoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRecibidoVentas.Location = new System.Drawing.Point(724, 70);
            this.lblRecibidoVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecibidoVentas.Name = "lblRecibidoVentas";
            this.lblRecibidoVentas.Size = new System.Drawing.Size(100, 29);
            this.lblRecibidoVentas.TabIndex = 97;
            this.lblRecibidoVentas.Text = "Recibido";
            // 
            // btnRealizarVentas
            // 
            this.btnRealizarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnRealizarVentas.Location = new System.Drawing.Point(730, 141);
            this.btnRealizarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRealizarVentas.Name = "btnRealizarVentas";
            this.btnRealizarVentas.Size = new System.Drawing.Size(102, 37);
            this.btnRealizarVentas.TabIndex = 99;
            this.btnRealizarVentas.Text = "Realizar";
            this.btnRealizarVentas.UseVisualStyleBackColor = true;
            this.btnRealizarVentas.Click += new System.EventHandler(this.btnRealizarVentas_Click);
            // 
            // btnEditarVentas
            // 
            this.btnEditarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVentas.Location = new System.Drawing.Point(908, 489);
            this.btnEditarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarVentas.Name = "btnEditarVentas";
            this.btnEditarVentas.Size = new System.Drawing.Size(112, 46);
            this.btnEditarVentas.TabIndex = 100;
            this.btnEditarVentas.Text = "Editar";
            this.btnEditarVentas.UseVisualStyleBackColor = true;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1164, 546);
            this.Controls.Add(this.btnEditarVentas);
            this.Controls.Add(this.btnRealizarVentas);
            this.Controls.Add(this.txtRecibidoVentas);
            this.Controls.Add(this.lblRecibidoVentas);
            this.Controls.Add(this.btnCerrarVentas);
            this.Controls.Add(this.txtTotalVentas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCambioVentas);
            this.Controls.Add(this.lblCambioVentas);
            this.Controls.Add(this.btnCancelarVentas);
            this.Controls.Add(this.dgvVentas);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1180, 585);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnCancelarVentas;
        private System.Windows.Forms.TextBox txtCambioVentas;
        private System.Windows.Forms.Label lblCambioVentas;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCerrarVentas;
        private System.Windows.Forms.TextBox txtRecibidoVentas;
        private System.Windows.Forms.Label lblRecibidoVentas;
        private System.Windows.Forms.Button btnRealizarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTotal;
        private System.Windows.Forms.Button btnEditarVentas;
    }
}