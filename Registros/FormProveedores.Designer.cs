﻿
namespace proyecto1
{
    partial class FormProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.lblcodigoProveedor = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.dgbProveedores = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDistribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnCerrarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.lblBuscarProveedor = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.txtEmailProveedor = new System.Windows.Forms.TextBox();
            this.lblEmailProveedor = new System.Windows.Forms.Label();
            this.txtProductoProveedor = new System.Windows.Forms.TextBox();
            this.lblProductoProveedor = new System.Windows.Forms.Label();
            this.txtDistribuidorProveedor = new System.Windows.Forms.TextBox();
            this.lblDistribuidorProveedor = new System.Windows.Forms.Label();
            this.btnEditarProveedores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(21, 14);
            this.pictureBoxCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(260, 219);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 66;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedor.Location = new System.Drawing.Point(717, 71);
            this.txtCodigoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtCodigoProveedor.TabIndex = 87;
            // 
            // lblcodigoProveedor
            // 
            this.lblcodigoProveedor.AutoSize = true;
            this.lblcodigoProveedor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoProveedor.Location = new System.Drawing.Point(580, 71);
            this.lblcodigoProveedor.Name = "lblcodigoProveedor";
            this.lblcodigoProveedor.Size = new System.Drawing.Size(117, 37);
            this.lblcodigoProveedor.TabIndex = 86;
            this.lblcodigoProveedor.Text = "Codigo: ";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(663, -7);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(231, 49);
            this.lblProveedores.TabIndex = 84;
            this.lblProveedores.Text = "Proveedores";
            // 
            // dgbProveedores
            // 
            this.dgbProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgbProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgbProveedores.ColumnHeadersHeight = 29;
            this.dgbProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigo,
            this.ColumnaNombre,
            this.ColumnaDistribuidor,
            this.ColumnaProducto,
            this.ColumnaEmail,
            this.ColumnaTelefono,
            this.ColumaDireccion});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbProveedores.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgbProveedores.Enabled = false;
            this.dgbProveedores.EnableHeadersVisualStyles = false;
            this.dgbProveedores.GridColor = System.Drawing.Color.Black;
            this.dgbProveedores.Location = new System.Drawing.Point(16, 417);
            this.dgbProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgbProveedores.Name = "dgbProveedores";
            this.dgbProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgbProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgbProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgbProveedores.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgbProveedores.Size = new System.Drawing.Size(1571, 231);
            this.dgbProveedores.TabIndex = 91;
            this.dgbProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbProveedores_CellContentClick);
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
            // ColumnaDistribuidor
            // 
            this.ColumnaDistribuidor.HeaderText = "Distribuidor";
            this.ColumnaDistribuidor.MinimumWidth = 6;
            this.ColumnaDistribuidor.Name = "ColumnaDistribuidor";
            this.ColumnaDistribuidor.Width = 210;
            // 
            // ColumnaProducto
            // 
            this.ColumnaProducto.HeaderText = "Producto";
            this.ColumnaProducto.MinimumWidth = 6;
            this.ColumnaProducto.Name = "ColumnaProducto";
            this.ColumnaProducto.Width = 125;
            // 
            // ColumnaEmail
            // 
            this.ColumnaEmail.HeaderText = "E-mail";
            this.ColumnaEmail.MinimumWidth = 6;
            this.ColumnaEmail.Name = "ColumnaEmail";
            this.ColumnaEmail.Width = 125;
            // 
            // ColumnaTelefono
            // 
            this.ColumnaTelefono.HeaderText = "Télefono";
            this.ColumnaTelefono.MinimumWidth = 6;
            this.ColumnaTelefono.Name = "ColumnaTelefono";
            this.ColumnaTelefono.Width = 125;
            // 
            // ColumaDireccion
            // 
            this.ColumaDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumaDireccion.HeaderText = "Direccion";
            this.ColumaDireccion.MinimumWidth = 6;
            this.ColumaDireccion.Name = "ColumaDireccion";
            this.ColumaDireccion.Width = 125;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(744, 354);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(136, 46);
            this.btnAgregarProveedor.TabIndex = 92;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.Location = new System.Drawing.Point(1193, 145);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(136, 46);
            this.btnBuscarProveedor.TabIndex = 94;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnCerrarProveedor
            // 
            this.btnCerrarProveedor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProveedor.Location = new System.Drawing.Point(1478, 675);
            this.btnCerrarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarProveedor.Name = "btnCerrarProveedor";
            this.btnCerrarProveedor.Size = new System.Drawing.Size(136, 46);
            this.btnCerrarProveedor.TabIndex = 95;
            this.btnCerrarProveedor.Text = "Cerrar";
            this.btnCerrarProveedor.UseVisualStyleBackColor = true;
            this.btnCerrarProveedor.Click += new System.EventHandler(this.btnCerrarProveedor_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProveedor.Location = new System.Drawing.Point(353, 655);
            this.btnGuardarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(136, 46);
            this.btnGuardarProveedor.TabIndex = 96;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(21, 655);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(136, 46);
            this.btnEliminarProveedor.TabIndex = 97;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProveedor.Location = new System.Drawing.Point(1175, 110);
            this.txtBuscarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtBuscarProveedor.TabIndex = 99;
            // 
            // lblBuscarProveedor
            // 
            this.lblBuscarProveedor.AutoSize = true;
            this.lblBuscarProveedor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProveedor.Location = new System.Drawing.Point(1205, 48);
            this.lblBuscarProveedor.Name = "lblBuscarProveedor";
            this.lblBuscarProveedor.Size = new System.Drawing.Size(118, 58);
            this.lblBuscarProveedor.TabIndex = 98;
            this.lblBuscarProveedor.Text = "Buscar\r\nproveedor";
            this.lblBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(717, 110);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtNombreProveedor.TabIndex = 101;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(564, 107);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(134, 37);
            this.lblNombreProveedor.TabIndex = 100;
            this.lblNombreProveedor.Text = "Nombre: ";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(717, 261);
            this.txtTelefonoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtTelefonoProveedor.TabIndex = 103;
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(559, 263);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(139, 37);
            this.lblTelefonoProveedor.TabIndex = 102;
            this.lblTelefonoProveedor.Text = "Télefono: ";
            // 
            // txtEmailProveedor
            // 
            this.txtEmailProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailProveedor.Location = new System.Drawing.Point(717, 223);
            this.txtEmailProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailProveedor.Name = "txtEmailProveedor";
            this.txtEmailProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtEmailProveedor.TabIndex = 105;
            // 
            // lblEmailProveedor
            // 
            this.lblEmailProveedor.AutoSize = true;
            this.lblEmailProveedor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProveedor.Location = new System.Drawing.Point(589, 225);
            this.lblEmailProveedor.Name = "lblEmailProveedor";
            this.lblEmailProveedor.Size = new System.Drawing.Size(108, 37);
            this.lblEmailProveedor.TabIndex = 104;
            this.lblEmailProveedor.Text = "E-mail: ";
            // 
            // txtProductoProveedor
            // 
            this.txtProductoProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoProveedor.Location = new System.Drawing.Point(717, 185);
            this.txtProductoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductoProveedor.Name = "txtProductoProveedor";
            this.txtProductoProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtProductoProveedor.TabIndex = 107;
            // 
            // lblProductoProveedor
            // 
            this.lblProductoProveedor.AutoSize = true;
            this.lblProductoProveedor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoProveedor.Location = new System.Drawing.Point(552, 185);
            this.lblProductoProveedor.Name = "lblProductoProveedor";
            this.lblProductoProveedor.Size = new System.Drawing.Size(146, 37);
            this.lblProductoProveedor.TabIndex = 106;
            this.lblProductoProveedor.Text = "Producto: ";
            // 
            // txtDistribuidorProveedor
            // 
            this.txtDistribuidorProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtDistribuidorProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistribuidorProveedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDistribuidorProveedor.Location = new System.Drawing.Point(717, 146);
            this.txtDistribuidorProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistribuidorProveedor.Name = "txtDistribuidorProveedor";
            this.txtDistribuidorProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtDistribuidorProveedor.TabIndex = 109;
            // 
            // lblDistribuidorProveedor
            // 
            this.lblDistribuidorProveedor.AutoSize = true;
            this.lblDistribuidorProveedor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistribuidorProveedor.Location = new System.Drawing.Point(515, 144);
            this.lblDistribuidorProveedor.Name = "lblDistribuidorProveedor";
            this.lblDistribuidorProveedor.Size = new System.Drawing.Size(180, 37);
            this.lblDistribuidorProveedor.TabIndex = 108;
            this.lblDistribuidorProveedor.Text = "Distribuidor: ";
            // 
            // btnEditarProveedores
            // 
            this.btnEditarProveedores.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedores.Location = new System.Drawing.Point(191, 655);
            this.btnEditarProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarProveedores.Name = "btnEditarProveedores";
            this.btnEditarProveedores.Size = new System.Drawing.Size(125, 44);
            this.btnEditarProveedores.TabIndex = 110;
            this.btnEditarProveedores.Text = "Editar";
            this.btnEditarProveedores.UseVisualStyleBackColor = true;
            this.btnEditarProveedores.Click += new System.EventHandler(this.btnEditarProveedores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1121, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionProveedor.Location = new System.Drawing.Point(549, 297);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(149, 37);
            this.lblDireccionProveedor.TabIndex = 112;
            this.lblDireccionProveedor.Text = "Dirección: ";
            this.lblDireccionProveedor.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionProveedor.Location = new System.Drawing.Point(717, 299);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(177, 32);
            this.txtDireccionProveedor.TabIndex = 113;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1924, 732);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.lblDireccionProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditarProveedores);
            this.Controls.Add(this.txtDistribuidorProveedor);
            this.Controls.Add(this.lblDistribuidorProveedor);
            this.Controls.Add(this.txtProductoProveedor);
            this.Controls.Add(this.lblProductoProveedor);
            this.Controls.Add(this.txtEmailProveedor);
            this.Controls.Add(this.lblEmailProveedor);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.lblTelefonoProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.txtBuscarProveedor);
            this.Controls.Add(this.lblBuscarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.btnCerrarProveedor);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.dgbProveedores);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.lblcodigoProveedor);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1363, 717);
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCuentas;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.Label lblcodigoProveedor;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.DataGridView dgbProveedores;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Button btnCerrarProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label lblBuscarProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.TextBox txtEmailProveedor;
        private System.Windows.Forms.Label lblEmailProveedor;
        private System.Windows.Forms.TextBox txtProductoProveedor;
        private System.Windows.Forms.Label lblProductoProveedor;
        private System.Windows.Forms.TextBox txtDistribuidorProveedor;
        private System.Windows.Forms.Label lblDistribuidorProveedor;
        private System.Windows.Forms.Button btnEditarProveedores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDistribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumaDireccion;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
    }
}