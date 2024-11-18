
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblNombreInventario = new System.Windows.Forms.Label();
            this.lblPrecioInventario = new System.Windows.Forms.Label();
            this.lblCantidadInventario = new System.Windows.Forms.Label();
            this.lblCodigoInventario = new System.Windows.Forms.Label();
            this.txtNombreInventario = new System.Windows.Forms.TextBox();
            this.txtPrecioCaja = new System.Windows.Forms.TextBox();
            this.txtCantidadCaja = new System.Windows.Forms.TextBox();
            this.txtCodigoInventario = new System.Windows.Forms.TextBox();
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
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblBlister = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtCantidadBlister = new System.Windows.Forms.TextBox();
            this.txtPrecioBlister = new System.Windows.Forms.TextBox();
            this.txtCantidadUnidad = new System.Windows.Forms.TextBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreBlister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBlister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventario.ColumnHeadersHeight = 29;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Codigo,
            this.Nombre,
            this.Area,
            this.PreCaja,
            this.PreBlister,
            this.PreUnidad,
            this.FechaIngreso,
            this.CCaja,
            this.CBlister,
            this.CUnidad,
            this.Vencimiento});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.Black;
            this.dgvInventario.Location = new System.Drawing.Point(13, 253);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInventario.Size = new System.Drawing.Size(1289, 278);
            this.dgvInventario.TabIndex = 63;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(481, 7);
            this.lblInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(181, 46);
            this.lblInventario.TabIndex = 65;
            this.lblInventario.Text = "Inventario";
            // 
            // lblNombreInventario
            // 
            this.lblNombreInventario.AutoSize = true;
            this.lblNombreInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInventario.Location = new System.Drawing.Point(305, 102);
            this.lblNombreInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreInventario.Name = "lblNombreInventario";
            this.lblNombreInventario.Size = new System.Drawing.Size(108, 29);
            this.lblNombreInventario.TabIndex = 66;
            this.lblNombreInventario.Text = "Nombre: ";
            // 
            // lblPrecioInventario
            // 
            this.lblPrecioInventario.AutoSize = true;
            this.lblPrecioInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioInventario.Location = new System.Drawing.Point(611, 191);
            this.lblPrecioInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioInventario.Name = "lblPrecioInventario";
            this.lblPrecioInventario.Size = new System.Drawing.Size(88, 29);
            this.lblPrecioInventario.TabIndex = 69;
            this.lblPrecioInventario.Text = "Precio: ";
            // 
            // lblCantidadInventario
            // 
            this.lblCantidadInventario.AutoSize = true;
            this.lblCantidadInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInventario.Location = new System.Drawing.Point(584, 162);
            this.lblCantidadInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadInventario.Name = "lblCantidadInventario";
            this.lblCantidadInventario.Size = new System.Drawing.Size(115, 29);
            this.lblCantidadInventario.TabIndex = 70;
            this.lblCantidadInventario.Text = "Cantidad: ";
            // 
            // lblCodigoInventario
            // 
            this.lblCodigoInventario.AutoSize = true;
            this.lblCodigoInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoInventario.Location = new System.Drawing.Point(318, 68);
            this.lblCodigoInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoInventario.Name = "lblCodigoInventario";
            this.lblCodigoInventario.Size = new System.Drawing.Size(94, 29);
            this.lblCodigoInventario.TabIndex = 71;
            this.lblCodigoInventario.Text = "Código: ";
            // 
            // txtNombreInventario
            // 
            this.txtNombreInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInventario.Location = new System.Drawing.Point(417, 104);
            this.txtNombreInventario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreInventario.Name = "txtNombreInventario";
            this.txtNombreInventario.Size = new System.Drawing.Size(134, 27);
            this.txtNombreInventario.TabIndex = 72;
            this.txtNombreInventario.TextChanged += new System.EventHandler(this.txtNombreInventario_TextChanged);
            // 
            // txtPrecioCaja
            // 
            this.txtPrecioCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtPrecioCaja.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCaja.Location = new System.Drawing.Point(704, 193);
            this.txtPrecioCaja.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCaja.Name = "txtPrecioCaja";
            this.txtPrecioCaja.Size = new System.Drawing.Size(73, 27);
            this.txtPrecioCaja.TabIndex = 75;
            // 
            // txtCantidadCaja
            // 
            this.txtCantidadCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtCantidadCaja.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCaja.Location = new System.Drawing.Point(704, 162);
            this.txtCantidadCaja.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadCaja.Name = "txtCantidadCaja";
            this.txtCantidadCaja.Size = new System.Drawing.Size(73, 27);
            this.txtCantidadCaja.TabIndex = 76;
            // 
            // txtCodigoInventario
            // 
            this.txtCodigoInventario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoInventario.Location = new System.Drawing.Point(417, 73);
            this.txtCodigoInventario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoInventario.Name = "txtCodigoInventario";
            this.txtCodigoInventario.Size = new System.Drawing.Size(134, 27);
            this.txtCodigoInventario.TabIndex = 77;
            // 
            // lblVencimintoInventario
            // 
            this.lblVencimintoInventario.AutoSize = true;
            this.lblVencimintoInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimintoInventario.Location = new System.Drawing.Point(756, 58);
            this.lblVencimintoInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimintoInventario.Name = "lblVencimintoInventario";
            this.lblVencimintoInventario.Size = new System.Drawing.Size(151, 29);
            this.lblVencimintoInventario.TabIndex = 79;
            this.lblVencimintoInventario.Text = "Vencimiento: ";
            // 
            // lblBuscarInventario
            // 
            this.lblBuscarInventario.AutoSize = true;
            this.lblBuscarInventario.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarInventario.Location = new System.Drawing.Point(1056, 58);
            this.lblBuscarInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarInventario.Name = "lblBuscarInventario";
            this.lblBuscarInventario.Size = new System.Drawing.Size(225, 29);
            this.lblBuscarInventario.TabIndex = 80;
            this.lblBuscarInventario.Text = "Buscar Medicamento";
            // 
            // txtBuscarInventario
            // 
            this.txtBuscarInventario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarInventario.Location = new System.Drawing.Point(1088, 100);
            this.txtBuscarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarInventario.Name = "txtBuscarInventario";
            this.txtBuscarInventario.Size = new System.Drawing.Size(162, 31);
            this.txtBuscarInventario.TabIndex = 81;
            this.txtBuscarInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarInventario_KeyPress);
            // 
            // dtpCalendarioInventario
            // 
            this.dtpCalendarioInventario.CalendarFont = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendarioInventario.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpCalendarioInventario.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpCalendarioInventario.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendarioInventario.Location = new System.Drawing.Point(673, 89);
            this.dtpCalendarioInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCalendarioInventario.Name = "dtpCalendarioInventario";
            this.dtpCalendarioInventario.Size = new System.Drawing.Size(301, 30);
            this.dtpCalendarioInventario.TabIndex = 82;
            // 
            // btnEliminarInventario
            // 
            this.btnEliminarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInventario.Location = new System.Drawing.Point(11, 558);
            this.btnEliminarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarInventario.Name = "btnEliminarInventario";
            this.btnEliminarInventario.Size = new System.Drawing.Size(102, 42);
            this.btnEliminarInventario.TabIndex = 83;
            this.btnEliminarInventario.Text = "Eliminar";
            this.btnEliminarInventario.UseVisualStyleBackColor = true;
            this.btnEliminarInventario.Click += new System.EventHandler(this.btnEliminarInventario_Click);
            // 
            // btnEditarInventario
            // 
            this.btnEditarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarInventario.Location = new System.Drawing.Point(135, 558);
            this.btnEditarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarInventario.Name = "btnEditarInventario";
            this.btnEditarInventario.Size = new System.Drawing.Size(101, 42);
            this.btnEditarInventario.TabIndex = 84;
            this.btnEditarInventario.Text = "Editar";
            this.btnEditarInventario.UseVisualStyleBackColor = true;
            this.btnEditarInventario.Click += new System.EventHandler(this.btnEditarInventario_Click);
            // 
            // btnCerrarInventario
            // 
            this.btnCerrarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInventario.Location = new System.Drawing.Point(1203, 558);
            this.btnCerrarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarInventario.Name = "btnCerrarInventario";
            this.btnCerrarInventario.Size = new System.Drawing.Size(99, 42);
            this.btnCerrarInventario.TabIndex = 85;
            this.btnCerrarInventario.Text = "Cerrar";
            this.btnCerrarInventario.UseVisualStyleBackColor = true;
            this.btnCerrarInventario.Click += new System.EventHandler(this.btnCerrarInventario_Click);
            // 
            // btnBuscarInventario
            // 
            this.btnBuscarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInventario.Location = new System.Drawing.Point(1123, 141);
            this.btnBuscarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarInventario.Name = "btnBuscarInventario";
            this.btnBuscarInventario.Size = new System.Drawing.Size(100, 40);
            this.btnBuscarInventario.TabIndex = 86;
            this.btnBuscarInventario.Text = "Buscar";
            this.btnBuscarInventario.UseVisualStyleBackColor = true;
            this.btnBuscarInventario.Click += new System.EventHandler(this.btnBuscarInventario_Click);
            // 
            // btnGuardarInventario
            // 
            this.btnGuardarInventario.Enabled = false;
            this.btnGuardarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarInventario.Location = new System.Drawing.Point(255, 558);
            this.btnGuardarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarInventario.Name = "btnGuardarInventario";
            this.btnGuardarInventario.Size = new System.Drawing.Size(125, 42);
            this.btnGuardarInventario.TabIndex = 87;
            this.btnGuardarInventario.Text = "Actualizar";
            this.btnGuardarInventario.UseVisualStyleBackColor = true;
            this.btnGuardarInventario.Click += new System.EventHandler(this.btnGuardarInventario_Click);
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInventario.Location = new System.Drawing.Point(438, 188);
            this.btnAgregarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(102, 37);
            this.btnAgregarInventario.TabIndex = 88;
            this.btnAgregarInventario.Text = "Nuevo";
            this.btnAgregarInventario.UseVisualStyleBackColor = true;
            this.btnAgregarInventario.Click += new System.EventHandler(this.btnAgregarInventario_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 611);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1310, 26);
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
            this.toolStripSplitButton1.Size = new System.Drawing.Size(79, 24);
            this.toolStripSplitButton1.Text = "Alertas";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // alertasToolStripMenuItem
            // 
            this.alertasToolStripMenuItem.Name = "alertasToolStripMenuItem";
            this.alertasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alertasToolStripMenuItem.Text = "Vencimientos";
            this.alertasToolStripMenuItem.Click += new System.EventHandler(this.alertasToolStripMenuItem_Click);
            // 
            // stockCasiVasioToolStripMenuItem
            // 
            this.stockCasiVasioToolStripMenuItem.Name = "stockCasiVasioToolStripMenuItem";
            this.stockCasiVasioToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.stockCasiVasioToolStripMenuItem.Text = "Bajos en stock";
            this.stockCasiVasioToolStripMenuItem.Click += new System.EventHandler(this.stockCasiVasioToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1038, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(195, 178);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 64;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cmbArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
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
            this.cmbArea.Location = new System.Drawing.Point(417, 136);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(2);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(134, 27);
            this.cmbArea.TabIndex = 92;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(340, 134);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(73, 29);
            this.lblArea.TabIndex = 91;
            this.lblArea.Text = "Área: ";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(709, 131);
            this.lblCaja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(56, 29);
            this.lblCaja.TabIndex = 94;
            this.lblCaja.Text = "Caja";
            // 
            // lblBlister
            // 
            this.lblBlister.AutoSize = true;
            this.lblBlister.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlister.Location = new System.Drawing.Point(788, 131);
            this.lblBlister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlister.Name = "lblBlister";
            this.lblBlister.Size = new System.Drawing.Size(77, 29);
            this.lblBlister.TabIndex = 95;
            this.lblBlister.Text = "Blister";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(875, 131);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(86, 29);
            this.lblUnidad.TabIndex = 96;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCantidadBlister
            // 
            this.txtCantidadBlister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtCantidadBlister.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadBlister.Location = new System.Drawing.Point(792, 162);
            this.txtCantidadBlister.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadBlister.Name = "txtCantidadBlister";
            this.txtCantidadBlister.Size = new System.Drawing.Size(73, 27);
            this.txtCantidadBlister.TabIndex = 98;
            // 
            // txtPrecioBlister
            // 
            this.txtPrecioBlister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtPrecioBlister.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBlister.Location = new System.Drawing.Point(792, 193);
            this.txtPrecioBlister.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioBlister.Name = "txtPrecioBlister";
            this.txtPrecioBlister.Size = new System.Drawing.Size(73, 27);
            this.txtPrecioBlister.TabIndex = 97;
            // 
            // txtCantidadUnidad
            // 
            this.txtCantidadUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtCantidadUnidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadUnidad.Location = new System.Drawing.Point(880, 162);
            this.txtCantidadUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadUnidad.Name = "txtCantidadUnidad";
            this.txtCantidadUnidad.Size = new System.Drawing.Size(73, 27);
            this.txtCantidadUnidad.TabIndex = 100;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtPrecioUnidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnidad.Location = new System.Drawing.Point(880, 193);
            this.txtPrecioUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(73, 27);
            this.txtPrecioUnidad.TabIndex = 99;
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
            this.IdProducto.Width = 112;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 82;
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
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "Área";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 125;
            // 
            // PreCaja
            // 
            this.PreCaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PreCaja.DataPropertyName = "PreCaja";
            this.PreCaja.HeaderText = "Pre.Caja";
            this.PreCaja.MinimumWidth = 6;
            this.PreCaja.Name = "PreCaja";
            this.PreCaja.ReadOnly = true;
            this.PreCaja.Width = 92;
            // 
            // PreBlister
            // 
            this.PreBlister.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PreBlister.DataPropertyName = "PreBlister";
            this.PreBlister.HeaderText = "Pre.Blister";
            this.PreBlister.MinimumWidth = 6;
            this.PreBlister.Name = "PreBlister";
            this.PreBlister.ReadOnly = true;
            this.PreBlister.Width = 109;
            // 
            // PreUnidad
            // 
            this.PreUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PreUnidad.DataPropertyName = "PreUnidad";
            this.PreUnidad.HeaderText = "Pre.Unidad";
            this.PreUnidad.MinimumWidth = 6;
            this.PreUnidad.Name = "PreUnidad";
            this.PreUnidad.ReadOnly = true;
            this.PreUnidad.Width = 113;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "F.ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 98;
            // 
            // CCaja
            // 
            this.CCaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CCaja.DataPropertyName = "CCaja";
            this.CCaja.HeaderText = "C. Caja";
            this.CCaja.Name = "CCaja";
            this.CCaja.ReadOnly = true;
            this.CCaja.Width = 81;
            // 
            // CBlister
            // 
            this.CBlister.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CBlister.DataPropertyName = "CBlister";
            this.CBlister.HeaderText = "C. Blister";
            this.CBlister.Name = "CBlister";
            this.CBlister.ReadOnly = true;
            this.CBlister.Width = 98;
            // 
            // CUnidad
            // 
            this.CUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CUnidad.DataPropertyName = "CUnidad";
            this.CUnidad.HeaderText = "C. Unidad";
            this.CUnidad.MinimumWidth = 6;
            this.CUnidad.Name = "CUnidad";
            this.CUnidad.ReadOnly = true;
            this.CUnidad.Width = 102;
            // 
            // Vencimiento
            // 
            this.Vencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Vencimiento.DataPropertyName = "Vencimiento";
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.MinimumWidth = 6;
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.ReadOnly = true;
            this.Vencimiento.Width = 123;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1310, 637);
            this.Controls.Add(this.txtCantidadUnidad);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.txtCantidadBlister);
            this.Controls.Add(this.txtPrecioBlister);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblBlister);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblArea);
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
            this.Controls.Add(this.txtCodigoInventario);
            this.Controls.Add(this.txtCantidadCaja);
            this.Controls.Add(this.txtPrecioCaja);
            this.Controls.Add(this.txtNombreInventario);
            this.Controls.Add(this.lblCodigoInventario);
            this.Controls.Add(this.lblCantidadInventario);
            this.Controls.Add(this.lblPrecioInventario);
            this.Controls.Add(this.lblNombreInventario);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Controls.Add(this.dgvInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1027, 591);
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
        private System.Windows.Forms.Label lblPrecioInventario;
        private System.Windows.Forms.Label lblCantidadInventario;
        private System.Windows.Forms.Label lblCodigoInventario;
        private System.Windows.Forms.TextBox txtNombreInventario;
        private System.Windows.Forms.TextBox txtPrecioCaja;
        private System.Windows.Forms.TextBox txtCantidadCaja;
        private System.Windows.Forms.TextBox txtCodigoInventario;
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
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lblBlister;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCantidadBlister;
        private System.Windows.Forms.TextBox txtPrecioBlister;
        private System.Windows.Forms.TextBox txtCantidadUnidad;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreBlister;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBlister;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
    }
}