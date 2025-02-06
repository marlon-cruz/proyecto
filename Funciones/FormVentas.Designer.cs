
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVentas = new System.Windows.Forms.Label();
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            this.txtCodigoVentas = new System.Windows.Forms.TextBox();
            this.txtCantidadVentas = new System.Windows.Forms.TextBox();
            this.txtMedicamentoVentas = new System.Windows.Forms.TextBox();
            this.lblCodigoVentas = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblMedicamentoVentas = new System.Windows.Forms.Label();
            this.cmbTipoVentas = new System.Windows.Forms.ComboBox();
            this.lblTipoVentas = new System.Windows.Forms.Label();
            this.btnAgregarVentas = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.dgvInventarioOpcion = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreBlister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBlister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantBlister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioOpcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblVentas.Location = new System.Drawing.Point(729, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(135, 49);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxCuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(260, 219);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 65;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // txtCodigoVentas
            // 
            this.txtCodigoVentas.Enabled = false;
            this.txtCodigoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodigoVentas.Location = new System.Drawing.Point(901, 81);
            this.txtCodigoVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoVentas.Name = "txtCodigoVentas";
            this.txtCodigoVentas.Size = new System.Drawing.Size(177, 32);
            this.txtCodigoVentas.TabIndex = 85;
            // 
            // txtCantidadVentas
            // 
            this.txtCantidadVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtCantidadVentas.Location = new System.Drawing.Point(901, 126);
            this.txtCantidadVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadVentas.Name = "txtCantidadVentas";
            this.txtCantidadVentas.Size = new System.Drawing.Size(177, 32);
            this.txtCantidadVentas.TabIndex = 84;
            // 
            // txtMedicamentoVentas
            // 
            this.txtMedicamentoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtMedicamentoVentas.Location = new System.Drawing.Point(512, 74);
            this.txtMedicamentoVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMedicamentoVentas.Name = "txtMedicamentoVentas";
            this.txtMedicamentoVentas.Size = new System.Drawing.Size(177, 32);
            this.txtMedicamentoVentas.TabIndex = 82;
            this.txtMedicamentoVentas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMedicamentoVentas_KeyUp);
            // 
            // lblCodigoVentas
            // 
            this.lblCodigoVentas.AutoSize = true;
            this.lblCodigoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblCodigoVentas.Location = new System.Drawing.Point(779, 81);
            this.lblCodigoVentas.Name = "lblCodigoVentas";
            this.lblCodigoVentas.Size = new System.Drawing.Size(117, 37);
            this.lblCodigoVentas.TabIndex = 81;
            this.lblCodigoVentas.Text = "Código: ";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantidadVentas.Location = new System.Drawing.Point(751, 119);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(144, 37);
            this.lblCantidadVentas.TabIndex = 80;
            this.lblCantidadVentas.Text = "Cantidad: ";
            // 
            // lblMedicamentoVentas
            // 
            this.lblMedicamentoVentas.AutoSize = true;
            this.lblMedicamentoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblMedicamentoVentas.Location = new System.Drawing.Point(301, 74);
            this.lblMedicamentoVentas.Name = "lblMedicamentoVentas";
            this.lblMedicamentoVentas.Size = new System.Drawing.Size(205, 37);
            this.lblMedicamentoVentas.TabIndex = 78;
            this.lblMedicamentoVentas.Text = "Medicamento: ";
            // 
            // cmbTipoVentas
            // 
            this.cmbTipoVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVentas.FormattingEnabled = true;
            this.cmbTipoVentas.Items.AddRange(new object[] {
            "Caja",
            "Blister",
            "Unidad"});
            this.cmbTipoVentas.Location = new System.Drawing.Point(512, 133);
            this.cmbTipoVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoVentas.Name = "cmbTipoVentas";
            this.cmbTipoVentas.Size = new System.Drawing.Size(177, 32);
            this.cmbTipoVentas.TabIndex = 87;
            // 
            // lblTipoVentas
            // 
            this.lblTipoVentas.AutoSize = true;
            this.lblTipoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTipoVentas.Location = new System.Drawing.Point(420, 128);
            this.lblTipoVentas.Name = "lblTipoVentas";
            this.lblTipoVentas.Size = new System.Drawing.Size(86, 37);
            this.lblTipoVentas.TabIndex = 86;
            this.lblTipoVentas.Text = "Tipo: ";
            // 
            // btnAgregarVentas
            // 
            this.btnAgregarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarVentas.Location = new System.Drawing.Point(695, 359);
            this.btnAgregarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarVentas.Name = "btnAgregarVentas";
            this.btnAgregarVentas.Size = new System.Drawing.Size(136, 46);
            this.btnAgregarVentas.TabIndex = 89;
            this.btnAgregarVentas.Text = "Agregar";
            this.btnAgregarVentas.UseVisualStyleBackColor = true;
            this.btnAgregarVentas.Click += new System.EventHandler(this.btnAgregarVentas_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
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
            this.Tipo,
            this.ColumnaCantidad,
            this.ColumnaPrecio,
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
            this.dgvVentas.Location = new System.Drawing.Point(69, 432);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
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
            this.dgvVentas.Size = new System.Drawing.Size(1528, 270);
            this.dgvVentas.TabIndex = 90;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.DataPropertyName = "Codigo";
            this.ColumnaCodigo.HeaderText = "Código";
            this.ColumnaCodigo.MinimumWidth = 6;
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.ReadOnly = true;
            this.ColumnaCodigo.Width = 210;
            // 
            // ColumnaMedicamento
            // 
            this.ColumnaMedicamento.DataPropertyName = "ColumnaMedicamento";
            this.ColumnaMedicamento.HeaderText = "Medicamento";
            this.ColumnaMedicamento.MinimumWidth = 6;
            this.ColumnaMedicamento.Name = "ColumnaMedicamento";
            this.ColumnaMedicamento.ReadOnly = true;
            this.ColumnaMedicamento.Width = 210;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 125;
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.DataPropertyName = "ColumnaCantidad";
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.MinimumWidth = 6;
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.ReadOnly = true;
            this.ColumnaCantidad.Width = 210;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.DataPropertyName = "ColumnaPrecio";
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.MinimumWidth = 6;
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            this.ColumnaPrecio.ReadOnly = true;
            this.ColumnaPrecio.Width = 125;
            // 
            // ColumnaTotal
            // 
            this.ColumnaTotal.DataPropertyName = "ColumnaTotal";
            this.ColumnaTotal.HeaderText = "total";
            this.ColumnaTotal.MinimumWidth = 6;
            this.ColumnaTotal.Name = "ColumnaTotal";
            this.ColumnaTotal.ReadOnly = true;
            this.ColumnaTotal.Width = 125;
            // 
            // btnCancelarVentas
            // 
            this.btnCancelarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelarVentas.Location = new System.Drawing.Point(108, 709);
            this.btnCancelarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarVentas.Name = "btnCancelarVentas";
            this.btnCancelarVentas.Size = new System.Drawing.Size(149, 57);
            this.btnCancelarVentas.TabIndex = 91;
            this.btnCancelarVentas.Text = "Cancelar";
            this.btnCancelarVentas.UseVisualStyleBackColor = true;
            this.btnCancelarVentas.Click += new System.EventHandler(this.btnCancelarVentas_Click);
            // 
            // txtCambioVentas
            // 
            this.txtCambioVentas.Enabled = false;
            this.txtCambioVentas.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioVentas.ForeColor = System.Drawing.Color.Black;
            this.txtCambioVentas.Location = new System.Drawing.Point(592, 720);
            this.txtCambioVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCambioVentas.Name = "txtCambioVentas";
            this.txtCambioVentas.Size = new System.Drawing.Size(73, 36);
            this.txtCambioVentas.TabIndex = 93;
            this.txtCambioVentas.Text = "0.00";
            // 
            // lblCambioVentas
            // 
            this.lblCambioVentas.AutoSize = true;
            this.lblCambioVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblCambioVentas.Location = new System.Drawing.Point(445, 721);
            this.lblCambioVentas.Name = "lblCambioVentas";
            this.lblCambioVentas.Size = new System.Drawing.Size(141, 37);
            this.lblCambioVentas.TabIndex = 92;
            this.lblCambioVentas.Text = "Cambio: $";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Enabled = false;
            this.txtTotalVentas.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.Location = new System.Drawing.Point(960, 721);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(71, 36);
            this.txtTotalVentas.TabIndex = 95;
            this.txtTotalVentas.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(856, 721);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 37);
            this.lblTotal.TabIndex = 94;
            this.lblTotal.Text = "Total: $";
            // 
            // btnCerrarVentas
            // 
            this.btnCerrarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVentas.Location = new System.Drawing.Point(1425, 710);
            this.btnCerrarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarVentas.Name = "btnCerrarVentas";
            this.btnCerrarVentas.Size = new System.Drawing.Size(149, 57);
            this.btnCerrarVentas.TabIndex = 96;
            this.btnCerrarVentas.Text = "Cerrar";
            this.btnCerrarVentas.UseVisualStyleBackColor = true;
            this.btnCerrarVentas.Click += new System.EventHandler(this.btnCerrarVentas_Click);
            // 
            // txtRecibidoVentas
            // 
            this.txtRecibidoVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtRecibidoVentas.Location = new System.Drawing.Point(1221, 110);
            this.txtRecibidoVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecibidoVentas.Name = "txtRecibidoVentas";
            this.txtRecibidoVentas.Size = new System.Drawing.Size(177, 32);
            this.txtRecibidoVentas.TabIndex = 98;
            // 
            // lblRecibidoVentas
            // 
            this.lblRecibidoVentas.AutoSize = true;
            this.lblRecibidoVentas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRecibidoVentas.Location = new System.Drawing.Point(1243, 59);
            this.lblRecibidoVentas.Name = "lblRecibidoVentas";
            this.lblRecibidoVentas.Size = new System.Drawing.Size(124, 37);
            this.lblRecibidoVentas.TabIndex = 97;
            this.lblRecibidoVentas.Text = "Recibido";
            // 
            // btnRealizarVentas
            // 
            this.btnRealizarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnRealizarVentas.Location = new System.Drawing.Point(1249, 145);
            this.btnRealizarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizarVentas.Name = "btnRealizarVentas";
            this.btnRealizarVentas.Size = new System.Drawing.Size(136, 46);
            this.btnRealizarVentas.TabIndex = 99;
            this.btnRealizarVentas.Text = "Realizar";
            this.btnRealizarVentas.UseVisualStyleBackColor = true;
            this.btnRealizarVentas.Click += new System.EventHandler(this.btnRealizarVentas_Click);
            // 
            // btnEditarVentas
            // 
            this.btnEditarVentas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVentas.Location = new System.Drawing.Point(1244, 710);
            this.btnEditarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarVentas.Name = "btnEditarVentas";
            this.btnEditarVentas.Size = new System.Drawing.Size(149, 57);
            this.btnEditarVentas.TabIndex = 100;
            this.btnEditarVentas.Text = "Eliminar";
            this.btnEditarVentas.UseVisualStyleBackColor = true;
            this.btnEditarVentas.Click += new System.EventHandler(this.btnEditarVentas_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturacion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.Location = new System.Drawing.Point(281, 710);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(111, 53);
            this.btnFacturacion.TabIndex = 101;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            // 
            // dgvInventarioOpcion
            // 
            this.dgvInventarioOpcion.AllowUserToAddRows = false;
            this.dgvInventarioOpcion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvInventarioOpcion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventarioOpcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgvInventarioOpcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventarioOpcion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioOpcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventarioOpcion.ColumnHeadersHeight = 29;
            this.dgvInventarioOpcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Codigo,
            this.Nombre,
            this.PreCaja,
            this.PreBlister,
            this.PreUnidad,
            this.CCaja,
            this.CBlister,
            this.CUnidad,
            this.CantCaja,
            this.CantBlister,
            this.CantUnidad});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventarioOpcion.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventarioOpcion.EnableHeadersVisualStyles = false;
            this.dgvInventarioOpcion.GridColor = System.Drawing.Color.Black;
            this.dgvInventarioOpcion.Location = new System.Drawing.Point(281, 208);
            this.dgvInventarioOpcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInventarioOpcion.Name = "dgvInventarioOpcion";
            this.dgvInventarioOpcion.ReadOnly = true;
            this.dgvInventarioOpcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventarioOpcion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioOpcion.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInventarioOpcion.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventarioOpcion.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInventarioOpcion.Size = new System.Drawing.Size(1112, 145);
            this.dgvInventarioOpcion.TabIndex = 102;
            this.dgvInventarioOpcion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventarioOpcion_CellClick);
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 143;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 103;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 210;
            // 
            // PreCaja
            // 
            this.PreCaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PreCaja.DataPropertyName = "PreCaja";
            this.PreCaja.HeaderText = "Pre.Caja";
            this.PreCaja.MinimumWidth = 6;
            this.PreCaja.Name = "PreCaja";
            this.PreCaja.ReadOnly = true;
            this.PreCaja.Width = 117;
            // 
            // PreBlister
            // 
            this.PreBlister.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PreBlister.DataPropertyName = "PreBlister";
            this.PreBlister.HeaderText = "Pre.Blister";
            this.PreBlister.MinimumWidth = 6;
            this.PreBlister.Name = "PreBlister";
            this.PreBlister.ReadOnly = true;
            this.PreBlister.Width = 135;
            // 
            // PreUnidad
            // 
            this.PreUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PreUnidad.DataPropertyName = "PreUnidad";
            this.PreUnidad.HeaderText = "Pre.Unidad";
            this.PreUnidad.MinimumWidth = 6;
            this.PreUnidad.Name = "PreUnidad";
            this.PreUnidad.ReadOnly = true;
            this.PreUnidad.Width = 143;
            // 
            // CCaja
            // 
            this.CCaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CCaja.DataPropertyName = "CCaja";
            this.CCaja.HeaderText = "C. Caja";
            this.CCaja.MinimumWidth = 6;
            this.CCaja.Name = "CCaja";
            this.CCaja.ReadOnly = true;
            this.CCaja.Width = 103;
            // 
            // CBlister
            // 
            this.CBlister.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CBlister.DataPropertyName = "CBlister";
            this.CBlister.HeaderText = "C. Blister";
            this.CBlister.MinimumWidth = 6;
            this.CBlister.Name = "CBlister";
            this.CBlister.ReadOnly = true;
            this.CBlister.Width = 121;
            // 
            // CUnidad
            // 
            this.CUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CUnidad.DataPropertyName = "CUnidad";
            this.CUnidad.HeaderText = "C. Unidad";
            this.CUnidad.MinimumWidth = 6;
            this.CUnidad.Name = "CUnidad";
            this.CUnidad.ReadOnly = true;
            this.CUnidad.Width = 129;
            // 
            // CantCaja
            // 
            this.CantCaja.DataPropertyName = "CantCaja";
            this.CantCaja.HeaderText = "CantCaja";
            this.CantCaja.MinimumWidth = 6;
            this.CantCaja.Name = "CantCaja";
            this.CantCaja.ReadOnly = true;
            this.CantCaja.Width = 125;
            // 
            // CantBlister
            // 
            this.CantBlister.DataPropertyName = "CantBlister";
            this.CantBlister.HeaderText = "CantBlister";
            this.CantBlister.MinimumWidth = 6;
            this.CantBlister.Name = "CantBlister";
            this.CantBlister.ReadOnly = true;
            this.CantBlister.Width = 125;
            // 
            // CantUnidad
            // 
            this.CantUnidad.DataPropertyName = "CantUnidad";
            this.CantUnidad.HeaderText = "CantUnidad";
            this.CantUnidad.MinimumWidth = 6;
            this.CantUnidad.Name = "CantUnidad";
            this.CantUnidad.ReadOnly = true;
            this.CantUnidad.Width = 125;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1540, 782);
            this.Controls.Add(this.dgvInventarioOpcion);
            this.Controls.Add(this.btnFacturacion);
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
            this.Controls.Add(this.txtMedicamentoVentas);
            this.Controls.Add(this.lblCodigoVentas);
            this.Controls.Add(this.lblCantidadVentas);
            this.Controls.Add(this.lblMedicamentoVentas);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Controls.Add(this.lblVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1362, 715);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioOpcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.PictureBox pictureBoxCuentas;
        private System.Windows.Forms.TextBox txtCodigoVentas;
        private System.Windows.Forms.TextBox txtCantidadVentas;
        private System.Windows.Forms.TextBox txtMedicamentoVentas;
        private System.Windows.Forms.Label lblCodigoVentas;
        private System.Windows.Forms.Label lblCantidadVentas;
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
        private System.Windows.Forms.Button btnEditarVentas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.DataGridView dgvInventarioOpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreBlister;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBlister;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantBlister;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantUnidad;
    }
}