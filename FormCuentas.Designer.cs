﻿
namespace proyecto1
{
    partial class FormCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBuscarCuenta = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarCuentas = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditarCuenta = new System.Windows.Forms.Button();
            this.btnEliminarCuenta = new System.Windows.Forms.Button();
            this.btnBuscarCuenta = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtUsuarioCuentas = new System.Windows.Forms.TextBox();
            this.textContraseñaCuentas = new System.Windows.Forms.TextBox();
            this.textNombreCuentas = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // lblBuscarCuenta
            // 
            this.lblBuscarCuenta.AutoSize = true;
            this.lblBuscarCuenta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuscarCuenta.Location = new System.Drawing.Point(659, 67);
            this.lblBuscarCuenta.Name = "lblBuscarCuenta";
            this.lblBuscarCuenta.Size = new System.Drawing.Size(135, 26);
            this.lblBuscarCuenta.TabIndex = 64;
            this.lblBuscarCuenta.Text = "Buscar Cuenta";
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBuscar.Location = new System.Drawing.Point(625, 107);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBuscar.Size = new System.Drawing.Size(189, 31);
            this.textBuscar.TabIndex = 63;
            this.textBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaUsuario,
            this.ColumnaContraseña});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.EnableHeadersVisualStyles = false;
            this.dgvCuentas.GridColor = System.Drawing.Color.Black;
            this.dgvCuentas.Location = new System.Drawing.Point(101, 265);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCuentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCuentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCuentas.Size = new System.Drawing.Size(672, 150);
            this.dgvCuentas.TabIndex = 62;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.Width = 210;
            // 
            // ColumnaUsuario
            // 
            this.ColumnaUsuario.HeaderText = "Usuario";
            this.ColumnaUsuario.Name = "ColumnaUsuario";
            this.ColumnaUsuario.Width = 210;
            // 
            // ColumnaContraseña
            // 
            this.ColumnaContraseña.HeaderText = "Contraseña";
            this.ColumnaContraseña.Name = "ColumnaContraseña";
            this.ColumnaContraseña.Width = 210;
            // 
            // btnCerrarCuentas
            // 
            this.btnCerrarCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCerrarCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarCuentas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrarCuentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarCuentas.Location = new System.Drawing.Point(677, 421);
            this.btnCerrarCuentas.Name = "btnCerrarCuentas";
            this.btnCerrarCuentas.Size = new System.Drawing.Size(137, 43);
            this.btnCerrarCuentas.TabIndex = 61;
            this.btnCerrarCuentas.Text = "Cerrar";
            this.btnCerrarCuentas.UseVisualStyleBackColor = false;
            this.btnCerrarCuentas.Click += new System.EventHandler(this.btnCerrarCuentas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(270, 421);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 43);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEditarCuenta
            // 
            this.btnEditarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnEditarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCuenta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnEditarCuenta.Location = new System.Drawing.Point(154, 421);
            this.btnEditarCuenta.Name = "btnEditarCuenta";
            this.btnEditarCuenta.Size = new System.Drawing.Size(110, 43);
            this.btnEditarCuenta.TabIndex = 59;
            this.btnEditarCuenta.Text = "Editar";
            this.btnEditarCuenta.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnEliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCuenta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(38, 421);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(110, 43);
            this.btnEliminarCuenta.TabIndex = 58;
            this.btnEliminarCuenta.Text = "Eliminar";
            this.btnEliminarCuenta.UseVisualStyleBackColor = false;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // btnBuscarCuenta
            // 
            this.btnBuscarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnBuscarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCuenta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCuenta.Location = new System.Drawing.Point(664, 154);
            this.btnBuscarCuenta.Name = "btnBuscarCuenta";
            this.btnBuscarCuenta.Size = new System.Drawing.Size(125, 43);
            this.btnBuscarCuenta.TabIndex = 57;
            this.btnBuscarCuenta.Text = "Buscar";
            this.btnBuscarCuenta.UseVisualStyleBackColor = false;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearCuenta.Location = new System.Drawing.Point(394, 177);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(150, 43);
            this.btnCrearCuenta.TabIndex = 56;
            this.btnCrearCuenta.Text = "Crear";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtUsuarioCuentas
            // 
            this.txtUsuarioCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtUsuarioCuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioCuentas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioCuentas.Location = new System.Drawing.Point(372, 103);
            this.txtUsuarioCuentas.Name = "txtUsuarioCuentas";
            this.txtUsuarioCuentas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsuarioCuentas.Size = new System.Drawing.Size(189, 31);
            this.txtUsuarioCuentas.TabIndex = 55;
            this.txtUsuarioCuentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioCuentas.TextChanged += new System.EventHandler(this.txtUsuarioCuentas_TextChanged);
            // 
            // textContraseñaCuentas
            // 
            this.textContraseñaCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.textContraseñaCuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContraseñaCuentas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textContraseñaCuentas.Location = new System.Drawing.Point(372, 140);
            this.textContraseñaCuentas.Name = "textContraseñaCuentas";
            this.textContraseñaCuentas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textContraseñaCuentas.Size = new System.Drawing.Size(189, 31);
            this.textContraseñaCuentas.TabIndex = 54;
            this.textContraseñaCuentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textContraseñaCuentas.TextChanged += new System.EventHandler(this.textContraseñaCuentas_TextChanged);
            // 
            // textNombreCuentas
            // 
            this.textNombreCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.textNombreCuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombreCuentas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreCuentas.Location = new System.Drawing.Point(372, 67);
            this.textNombreCuentas.Name = "textNombreCuentas";
            this.textNombreCuentas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textNombreCuentas.Size = new System.Drawing.Size(189, 31);
            this.textNombreCuentas.TabIndex = 53;
            this.textNombreCuentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNombreCuentas.TextChanged += new System.EventHandler(this.textNombreCuentas_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Location = new System.Drawing.Point(233, 142);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(115, 26);
            this.lblContraseña.TabIndex = 52;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(264, 105);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 26);
            this.lblUsuario.TabIndex = 51;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(259, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 26);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCuentas.Location = new System.Drawing.Point(399, 9);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(145, 45);
            this.lblCuentas.TabIndex = 49;
            this.lblCuentas.Text = "Cuentas";
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(38, 38);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(175, 156);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 48;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(853, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBuscarCuenta);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.btnCerrarCuentas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditarCuenta);
            this.Controls.Add(this.btnEliminarCuenta);
            this.Controls.Add(this.btnBuscarCuenta);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.txtUsuarioCuentas);
            this.Controls.Add(this.textContraseñaCuentas);
            this.Controls.Add(this.textNombreCuentas);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Cuentas";
            this.Load += new System.EventHandler(this.FormCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBuscarCuenta;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaContraseña;
        private System.Windows.Forms.Button btnCerrarCuentas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditarCuenta;
        private System.Windows.Forms.Button btnEliminarCuenta;
        private System.Windows.Forms.Button btnBuscarCuenta;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtUsuarioCuentas;
        private System.Windows.Forms.TextBox textContraseñaCuentas;
        private System.Windows.Forms.TextBox textNombreCuentas;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.PictureBox pictureBoxCuentas;
    }
}