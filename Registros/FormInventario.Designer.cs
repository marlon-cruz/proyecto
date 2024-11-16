
namespace proyecto1
{
    partial class FormInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblNombreInventario = new System.Windows.Forms.Label();
            this.lblTipoInventario = new System.Windows.Forms.Label();
            this.lblPdescuentoInventario = new System.Windows.Forms.Label();
            this.lblPrecioInventario = new System.Windows.Forms.Label();
            this.lblCantidadInventario = new System.Windows.Forms.Label();
            this.lblCodigoInventario = new System.Windows.Forms.Label();
            this.txtNombreInventario = new System.Windows.Forms.TextBox();
            this.txtPdescuentoInventario = new System.Windows.Forms.TextBox();
            this.txtPrecioInventario = new System.Windows.Forms.TextBox();
            this.txtCantidadInventario = new System.Windows.Forms.TextBox();
            this.txtCodigoInventario = new System.Windows.Forms.TextBox();
            this.cmbTipoInventario = new System.Windows.Forms.ComboBox();
            this.lblVencimintoInventario = new System.Windows.Forms.Label();
            this.lblBuscarInventario = new System.Windows.Forms.Label();
            this.txtBuscarInventario = new System.Windows.Forms.TextBox();
            this.dtpCalendarioInventario = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarInventario = new System.Windows.Forms.Button();
            this.btnEditarInventario = new System.Windows.Forms.Button();
            this.btnCerrarInventario = new System.Windows.Forms.Button();
            this.btnBuscarInventario = new System.Windows.Forms.Button();
            this.btnGuardarInventario = new System.Windows.Forms.Button();
            this.btnAgregarInventario = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.alertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockCasiVasioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBlister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.ColumnHeadersHeight = 29;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.PDescuento,
            this.PCaja,
            this.pUnidad,
            this.PBlister,
            this.Tipo,
            this.Area,
            this.Vencimiento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.Enabled = false;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.Black;
            this.dgvInventario.Location = new System.Drawing.Point(13, 399);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventario.Size = new System.Drawing.Size(1522, 196);
            this.dgvInventario.TabIndex = 63;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbInventario_CellContentClick);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(641, 9);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(226, 58);
            this.lblInventario.TabIndex = 65;
            this.lblInventario.Text = "Inventario";
            // 
            // lblNombreInventario
            // 
            this.lblNombreInventario.AutoSize = true;
            this.lblNombreInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInventario.Location = new System.Drawing.Point(439, 128);
            this.lblNombreInventario.Name = "lblNombreInventario";
            this.lblNombreInventario.Size = new System.Drawing.Size(134, 37);
            this.lblNombreInventario.TabIndex = 66;
            this.lblNombreInventario.Text = "Nombre: ";
            // 
            // lblTipoInventario
            // 
            this.lblTipoInventario.AutoSize = true;
            this.lblTipoInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInventario.Location = new System.Drawing.Point(492, 297);
            this.lblTipoInventario.Name = "lblTipoInventario";
            this.lblTipoInventario.Size = new System.Drawing.Size(86, 37);
            this.lblTipoInventario.TabIndex = 67;
            this.lblTipoInventario.Text = "Tipo: ";
            // 
            // lblPdescuentoInventario
            // 
            this.lblPdescuentoInventario.AutoSize = true;
            this.lblPdescuentoInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdescuentoInventario.Location = new System.Drawing.Point(388, 255);
            this.lblPdescuentoInventario.Name = "lblPdescuentoInventario";
            this.lblPdescuentoInventario.Size = new System.Drawing.Size(185, 37);
            this.lblPdescuentoInventario.TabIndex = 68;
            this.lblPdescuentoInventario.Text = "P.Descuento: ";
            // 
            // lblPrecioInventario
            // 
            this.lblPrecioInventario.AutoSize = true;
            this.lblPrecioInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioInventario.Location = new System.Drawing.Point(467, 213);
            this.lblPrecioInventario.Name = "lblPrecioInventario";
            this.lblPrecioInventario.Size = new System.Drawing.Size(110, 37);
            this.lblPrecioInventario.TabIndex = 69;
            this.lblPrecioInventario.Text = "Precio: ";
            // 
            // lblCantidadInventario
            // 
            this.lblCantidadInventario.AutoSize = true;
            this.lblCantidadInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInventario.Location = new System.Drawing.Point(431, 165);
            this.lblCantidadInventario.Name = "lblCantidadInventario";
            this.lblCantidadInventario.Size = new System.Drawing.Size(144, 37);
            this.lblCantidadInventario.TabIndex = 70;
            this.lblCantidadInventario.Text = "Cantidad: ";
            // 
            // lblCodigoInventario
            // 
            this.lblCodigoInventario.AutoSize = true;
            this.lblCodigoInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoInventario.Location = new System.Drawing.Point(456, 85);
            this.lblCodigoInventario.Name = "lblCodigoInventario";
            this.lblCodigoInventario.Size = new System.Drawing.Size(117, 37);
            this.lblCodigoInventario.TabIndex = 71;
            this.lblCodigoInventario.Text = "Código: ";
            // 
            // txtNombreInventario
            // 
            this.txtNombreInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInventario.Location = new System.Drawing.Point(589, 128);
            this.txtNombreInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreInventario.Name = "txtNombreInventario";
            this.txtNombreInventario.Size = new System.Drawing.Size(177, 32);
            this.txtNombreInventario.TabIndex = 72;
            // 
            // txtPdescuentoInventario
            // 
            this.txtPdescuentoInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPdescuentoInventario.Location = new System.Drawing.Point(589, 255);
            this.txtPdescuentoInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPdescuentoInventario.Name = "txtPdescuentoInventario";
            this.txtPdescuentoInventario.Size = new System.Drawing.Size(177, 32);
            this.txtPdescuentoInventario.TabIndex = 74;
            // 
            // txtPrecioInventario
            // 
            this.txtPrecioInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioInventario.Location = new System.Drawing.Point(589, 213);
            this.txtPrecioInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioInventario.Name = "txtPrecioInventario";
            this.txtPrecioInventario.Size = new System.Drawing.Size(177, 32);
            this.txtPrecioInventario.TabIndex = 75;
            // 
            // txtCantidadInventario
            // 
            this.txtCantidadInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadInventario.Location = new System.Drawing.Point(589, 167);
            this.txtCantidadInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadInventario.Name = "txtCantidadInventario";
            this.txtCantidadInventario.Size = new System.Drawing.Size(177, 32);
            this.txtCantidadInventario.TabIndex = 76;
            // 
            // txtCodigoInventario
            // 
            this.txtCodigoInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoInventario.Location = new System.Drawing.Point(589, 85);
            this.txtCodigoInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoInventario.Name = "txtCodigoInventario";
            this.txtCodigoInventario.Size = new System.Drawing.Size(177, 32);
            this.txtCodigoInventario.TabIndex = 77;
            // 
            // cmbTipoInventario
            // 
            this.cmbTipoInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cmbTipoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoInventario.FormattingEnabled = true;
            this.cmbTipoInventario.Items.AddRange(new object[] {
            "Unidad",
            "Blister",
            "Caja"});
            this.cmbTipoInventario.Location = new System.Drawing.Point(589, 297);
            this.cmbTipoInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoInventario.Name = "cmbTipoInventario";
            this.cmbTipoInventario.Size = new System.Drawing.Size(177, 32);
            this.cmbTipoInventario.TabIndex = 78;
            // 
            // lblVencimintoInventario
            // 
            this.lblVencimintoInventario.AutoSize = true;
            this.lblVencimintoInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimintoInventario.Location = new System.Drawing.Point(913, 68);
            this.lblVencimintoInventario.Name = "lblVencimintoInventario";
            this.lblVencimintoInventario.Size = new System.Drawing.Size(187, 37);
            this.lblVencimintoInventario.TabIndex = 79;
            this.lblVencimintoInventario.Text = "Vencimiento: ";
            // 
            // lblBuscarInventario
            // 
            this.lblBuscarInventario.AutoSize = true;
            this.lblBuscarInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarInventario.Location = new System.Drawing.Point(1223, 57);
            this.lblBuscarInventario.Name = "lblBuscarInventario";
            this.lblBuscarInventario.Size = new System.Drawing.Size(281, 37);
            this.lblBuscarInventario.TabIndex = 80;
            this.lblBuscarInventario.Text = "Buscar Medicamento";
            // 
            // txtBuscarInventario
            // 
            this.txtBuscarInventario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarInventario.Location = new System.Drawing.Point(1265, 108);
            this.txtBuscarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarInventario.Name = "txtBuscarInventario";
            this.txtBuscarInventario.Size = new System.Drawing.Size(215, 36);
            this.txtBuscarInventario.TabIndex = 81;
            // 
            // dtpCalendarioInventario
            // 
            this.dtpCalendarioInventario.CalendarFont = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendarioInventario.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpCalendarioInventario.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpCalendarioInventario.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendarioInventario.Location = new System.Drawing.Point(809, 108);
            this.dtpCalendarioInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCalendarioInventario.Name = "dtpCalendarioInventario";
            this.dtpCalendarioInventario.Size = new System.Drawing.Size(400, 36);
            this.dtpCalendarioInventario.TabIndex = 82;
            // 
            // btnEliminarInventario
            // 
            this.btnEliminarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInventario.Location = new System.Drawing.Point(13, 607);
            this.btnEliminarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarInventario.Name = "btnEliminarInventario";
            this.btnEliminarInventario.Size = new System.Drawing.Size(136, 52);
            this.btnEliminarInventario.TabIndex = 83;
            this.btnEliminarInventario.Text = "Eliminar";
            this.btnEliminarInventario.UseVisualStyleBackColor = true;
            this.btnEliminarInventario.Click += new System.EventHandler(this.btnEliminarInventario_Click);
            // 
            // btnEditarInventario
            // 
            this.btnEditarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarInventario.Location = new System.Drawing.Point(179, 607);
            this.btnEditarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarInventario.Name = "btnEditarInventario";
            this.btnEditarInventario.Size = new System.Drawing.Size(135, 52);
            this.btnEditarInventario.TabIndex = 84;
            this.btnEditarInventario.Text = "Editar";
            this.btnEditarInventario.UseVisualStyleBackColor = true;
            this.btnEditarInventario.Click += new System.EventHandler(this.btnEditarInventario_Click);
            // 
            // btnCerrarInventario
            // 
            this.btnCerrarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInventario.Location = new System.Drawing.Point(1391, 601);
            this.btnCerrarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarInventario.Name = "btnCerrarInventario";
            this.btnCerrarInventario.Size = new System.Drawing.Size(132, 58);
            this.btnCerrarInventario.TabIndex = 85;
            this.btnCerrarInventario.Text = "Cerrar";
            this.btnCerrarInventario.UseVisualStyleBackColor = true;
            this.btnCerrarInventario.Click += new System.EventHandler(this.btnCerrarInventario_Click);
            // 
            // btnBuscarInventario
            // 
            this.btnBuscarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInventario.Location = new System.Drawing.Point(1312, 159);
            this.btnBuscarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarInventario.Name = "btnBuscarInventario";
            this.btnBuscarInventario.Size = new System.Drawing.Size(133, 49);
            this.btnBuscarInventario.TabIndex = 86;
            this.btnBuscarInventario.Text = "Buscar";
            this.btnBuscarInventario.UseVisualStyleBackColor = true;
            this.btnBuscarInventario.Click += new System.EventHandler(this.btnBuscarInventario_Click);
            // 
            // btnGuardarInventario
            // 
            this.btnGuardarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarInventario.Location = new System.Drawing.Point(339, 607);
            this.btnGuardarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarInventario.Name = "btnGuardarInventario";
            this.btnGuardarInventario.Size = new System.Drawing.Size(136, 52);
            this.btnGuardarInventario.TabIndex = 87;
            this.btnGuardarInventario.Text = "Guardar";
            this.btnGuardarInventario.UseVisualStyleBackColor = true;
            this.btnGuardarInventario.Click += new System.EventHandler(this.btnGuardarInventario_Click);
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInventario.Location = new System.Drawing.Point(731, 347);
            this.btnAgregarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(136, 46);
            this.btnAgregarInventario.TabIndex = 88;
            this.btnAgregarInventario.Text = "Agregar";
            this.btnAgregarInventario.UseVisualStyleBackColor = true;
            this.btnAgregarInventario.Click += new System.EventHandler(this.btnAgregarInventario_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1782, 26);
            this.statusStrip1.TabIndex = 90;
            this.statusStrip1.Text = "Alertas";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertasToolStripMenuItem,
            this.stockCasiVasioToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::proyecto1.Properties.Resources.icono_de_vencimiento;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(94, 24);
            this.toolStripSplitButton1.Text = "Alertas";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // alertasToolStripMenuItem
            // 
            this.alertasToolStripMenuItem.Name = "alertasToolStripMenuItem";
            this.alertasToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.alertasToolStripMenuItem.Text = "Vencimientos";
            this.alertasToolStripMenuItem.Click += new System.EventHandler(this.alertasToolStripMenuItem_Click);
            // 
            // stockCasiVasioToolStripMenuItem
            // 
            this.stockCasiVasioToolStripMenuItem.Name = "stockCasiVasioToolStripMenuItem";
            this.stockCasiVasioToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.stockCasiVasioToolStripMenuItem.Text = "Bajos en stock";
            this.stockCasiVasioToolStripMenuItem.Click += new System.EventHandler(this.stockCasiVasioToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1229, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(260, 219);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 64;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inyectable",
            "Oral",
            "Tópico",
            "Óptico/Oftálmico",
            "Ótico",
            "Nasal",
            "Inhalable",
            "Rectal",
            "Vaginal",
            "Sublingual/Bucal",
            "Analgésicos",
            "Antibióticos",
            "Antidepresivos",
            "Antihistamínicos",
            "Antiinflamatorios"});
            this.comboBox1.Location = new System.Drawing.Point(875, 302);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 32);
            this.comboBox1.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 91;
            this.label1.Text = "Área: ";
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
            this.Codigo.Width = 103;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 210;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 123;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 97;
            // 
            // PDescuento
            // 
            this.PDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PDescuento.DataPropertyName = "PDescuento";
            this.PDescuento.HeaderText = "Precio %";
            this.PDescuento.MinimumWidth = 6;
            this.PDescuento.Name = "PDescuento";
            this.PDescuento.Width = 118;
            // 
            // PCaja
            // 
            this.PCaja.HeaderText = "Precio Caja";
            this.PCaja.MinimumWidth = 6;
            this.PCaja.Name = "PCaja";
            this.PCaja.ReadOnly = true;
            this.PCaja.Width = 150;
            // 
            // pUnidad
            // 
            this.pUnidad.HeaderText = "Precio Unidad";
            this.pUnidad.MinimumWidth = 6;
            this.pUnidad.Name = "pUnidad";
            this.pUnidad.ReadOnly = true;
            this.pUnidad.Width = 125;
            // 
            // PBlister
            // 
            this.PBlister.HeaderText = "Precio Blister";
            this.PBlister.MinimumWidth = 6;
            this.PBlister.Name = "PBlister";
            this.PBlister.ReadOnly = true;
            this.PBlister.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "Área";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 125;
            // 
            // Vencimiento
            // 
            this.Vencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Vencimiento.DataPropertyName = "Vencimiento";
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.MinimumWidth = 6;
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.Width = 155;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1782, 697);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregarInventario);
            this.Controls.Add(this.btnGuardarInventario);
            this.Controls.Add(this.btnBuscarInventario);
            this.Controls.Add(this.btnCerrarInventario);
            this.Controls.Add(this.btnEditarInventario);
            this.Controls.Add(this.btnEliminarInventario);
            this.Controls.Add(this.dtpCalendarioInventario);
            this.Controls.Add(this.txtBuscarInventario);
            this.Controls.Add(this.lblBuscarInventario);
            this.Controls.Add(this.lblVencimintoInventario);
            this.Controls.Add(this.cmbTipoInventario);
            this.Controls.Add(this.txtCodigoInventario);
            this.Controls.Add(this.txtCantidadInventario);
            this.Controls.Add(this.txtPrecioInventario);
            this.Controls.Add(this.txtPdescuentoInventario);
            this.Controls.Add(this.txtNombreInventario);
            this.Controls.Add(this.lblCodigoInventario);
            this.Controls.Add(this.lblCantidadInventario);
            this.Controls.Add(this.lblPrecioInventario);
            this.Controls.Add(this.lblPdescuentoInventario);
            this.Controls.Add(this.lblTipoInventario);
            this.Controls.Add(this.lblNombreInventario);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Controls.Add(this.dgvInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1566, 719);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Inventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.PictureBox pictureBoxCuentas;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblNombreInventario;
        private System.Windows.Forms.Label lblTipoInventario;
        private System.Windows.Forms.Label lblPdescuentoInventario;
        private System.Windows.Forms.Label lblPrecioInventario;
        private System.Windows.Forms.Label lblCantidadInventario;
        private System.Windows.Forms.Label lblCodigoInventario;
        private System.Windows.Forms.TextBox txtNombreInventario;
        private System.Windows.Forms.TextBox txtPdescuentoInventario;
        private System.Windows.Forms.TextBox txtPrecioInventario;
        private System.Windows.Forms.TextBox txtCantidadInventario;
        private System.Windows.Forms.TextBox txtCodigoInventario;
        private System.Windows.Forms.ComboBox cmbTipoInventario;
        private System.Windows.Forms.Label lblVencimintoInventario;
        private System.Windows.Forms.Label lblBuscarInventario;
        private System.Windows.Forms.TextBox txtBuscarInventario;
        private System.Windows.Forms.DateTimePicker dtpCalendarioInventario;
        private System.Windows.Forms.Button btnEliminarInventario;
        private System.Windows.Forms.Button btnEditarInventario;
        private System.Windows.Forms.Button btnCerrarInventario;
        private System.Windows.Forms.Button btnBuscarInventario;
        private System.Windows.Forms.Button btnGuardarInventario;
        private System.Windows.Forms.Button btnAgregarInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem alertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockCasiVasioToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBlister;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
    }
}