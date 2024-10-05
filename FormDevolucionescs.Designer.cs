
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            this.lblDevoluciones = new System.Windows.Forms.Label();
            this.lblMotivoDevoluciones = new System.Windows.Forms.Label();
            this.txtDescripcionDevoluciones = new System.Windows.Forms.TextBox();
            this.lblDescripcionDevoluciones = new System.Windows.Forms.Label();
            this.txtFacturaDevoluciones = new System.Windows.Forms.TextBox();
            this.lblNFacturaDevoluciones = new System.Windows.Forms.Label();
            this.btnRealizarDevoluciones = new System.Windows.Forms.Button();
            this.btnCerrarDevoluciones = new System.Windows.Forms.Button();
            this.btnCancelarDevolucion = new System.Windows.Forms.Button();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.NFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnErrorEleccion = new System.Windows.Forms.RadioButton();
            this.rbtnDesperfecto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCuentas.Image")));
            this.pictureBoxCuentas.Location = new System.Drawing.Point(13, 14);
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
            this.lblDevoluciones.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblDevoluciones.Location = new System.Drawing.Point(628, 18);
            this.lblDevoluciones.Name = "lblDevoluciones";
            this.lblDevoluciones.Size = new System.Drawing.Size(245, 49);
            this.lblDevoluciones.TabIndex = 67;
            this.lblDevoluciones.Text = "Devoluciones";
            // 
            // lblMotivoDevoluciones
            // 
            this.lblMotivoDevoluciones.AutoSize = true;
            this.lblMotivoDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoDevoluciones.Location = new System.Drawing.Point(465, 277);
            this.lblMotivoDevoluciones.Name = "lblMotivoDevoluciones";
            this.lblMotivoDevoluciones.Size = new System.Drawing.Size(115, 37);
            this.lblMotivoDevoluciones.TabIndex = 90;
            this.lblMotivoDevoluciones.Text = "Motivo:";
            // 
            // txtDescripcionDevoluciones
            // 
            this.txtDescripcionDevoluciones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDevoluciones.Location = new System.Drawing.Point(612, 164);
            this.txtDescripcionDevoluciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionDevoluciones.Multiline = true;
            this.txtDescripcionDevoluciones.Name = "txtDescripcionDevoluciones";
            this.txtDescripcionDevoluciones.Size = new System.Drawing.Size(405, 102);
            this.txtDescripcionDevoluciones.TabIndex = 89;
            // 
            // lblDescripcionDevoluciones
            // 
            this.lblDescripcionDevoluciones.AutoSize = true;
            this.lblDescripcionDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDevoluciones.Location = new System.Drawing.Point(403, 158);
            this.lblDescripcionDevoluciones.Name = "lblDescripcionDevoluciones";
            this.lblDescripcionDevoluciones.Size = new System.Drawing.Size(177, 37);
            this.lblDescripcionDevoluciones.TabIndex = 88;
            this.lblDescripcionDevoluciones.Text = "Descripción: ";
            // 
            // txtFacturaDevoluciones
            // 
            this.txtFacturaDevoluciones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaDevoluciones.Location = new System.Drawing.Point(612, 120);
            this.txtFacturaDevoluciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFacturaDevoluciones.Name = "txtFacturaDevoluciones";
            this.txtFacturaDevoluciones.Size = new System.Drawing.Size(229, 32);
            this.txtFacturaDevoluciones.TabIndex = 93;
            // 
            // lblNFacturaDevoluciones
            // 
            this.lblNFacturaDevoluciones.AutoSize = true;
            this.lblNFacturaDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblNFacturaDevoluciones.Location = new System.Drawing.Point(423, 114);
            this.lblNFacturaDevoluciones.Name = "lblNFacturaDevoluciones";
            this.lblNFacturaDevoluciones.Size = new System.Drawing.Size(161, 37);
            this.lblNFacturaDevoluciones.TabIndex = 92;
            this.lblNFacturaDevoluciones.Text = "N° Factura: ";
            // 
            // btnRealizarDevoluciones
            // 
            this.btnRealizarDevoluciones.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnRealizarDevoluciones.Location = new System.Drawing.Point(674, 583);
            this.btnRealizarDevoluciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizarDevoluciones.Name = "btnRealizarDevoluciones";
            this.btnRealizarDevoluciones.Size = new System.Drawing.Size(199, 55);
            this.btnRealizarDevoluciones.TabIndex = 94;
            this.btnRealizarDevoluciones.Text = "Realizar\r\ndevolucion";
            this.btnRealizarDevoluciones.UseVisualStyleBackColor = true;
            this.btnRealizarDevoluciones.Click += new System.EventHandler(this.btnRealizarDevoluciones_Click);
            // 
            // btnCerrarDevoluciones
            // 
            this.btnCerrarDevoluciones.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDevoluciones.Location = new System.Drawing.Point(1108, 592);
            this.btnCerrarDevoluciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarDevoluciones.Name = "btnCerrarDevoluciones";
            this.btnCerrarDevoluciones.Size = new System.Drawing.Size(156, 55);
            this.btnCerrarDevoluciones.TabIndex = 95;
            this.btnCerrarDevoluciones.Text = "Cerrar";
            this.btnCerrarDevoluciones.UseVisualStyleBackColor = true;
            this.btnCerrarDevoluciones.Click += new System.EventHandler(this.btnCerrarDevoluciones_Click);
            // 
            // btnCancelarDevolucion
            // 
            this.btnCancelarDevolucion.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDevolucion.Location = new System.Drawing.Point(242, 583);
            this.btnCancelarDevolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarDevolucion.Name = "btnCancelarDevolucion";
            this.btnCancelarDevolucion.Size = new System.Drawing.Size(156, 55);
            this.btnCancelarDevolucion.TabIndex = 97;
            this.btnCancelarDevolucion.Text = "Cancelar";
            this.btnCancelarDevolucion.UseVisualStyleBackColor = true;
            this.btnCancelarDevolucion.Click += new System.EventHandler(this.btnCancelarDevolucion_Click);
            // 
            // dgvDevoluciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevoluciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevoluciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDevoluciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.dgvDevoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDevoluciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevoluciones.ColumnHeadersHeight = 29;
            this.dgvDevoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NFactura,
            this.Descripcion,
            this.Motivo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevoluciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDevoluciones.EnableHeadersVisualStyles = false;
            this.dgvDevoluciones.GridColor = System.Drawing.Color.Black;
            this.dgvDevoluciones.Location = new System.Drawing.Point(410, 376);
            this.dgvDevoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDevoluciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevoluciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDevoluciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDevoluciones.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDevoluciones.Size = new System.Drawing.Size(785, 210);
            this.dgvDevoluciones.TabIndex = 98;
            // 
            // NFactura
            // 
            this.NFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NFactura.HeaderText = "N° Factura";
            this.NFactura.MinimumWidth = 6;
            this.NFactura.Name = "NFactura";
            this.NFactura.ReadOnly = true;
            this.NFactura.Width = 135;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 146;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.MinimumWidth = 6;
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 150;
            // 
            // rbtnErrorEleccion
            // 
            this.rbtnErrorEleccion.AutoSize = true;
            this.rbtnErrorEleccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnErrorEleccion.ForeColor = System.Drawing.Color.White;
            this.rbtnErrorEleccion.Location = new System.Drawing.Point(625, 325);
            this.rbtnErrorEleccion.Name = "rbtnErrorEleccion";
            this.rbtnErrorEleccion.Size = new System.Drawing.Size(172, 28);
            this.rbtnErrorEleccion.TabIndex = 100;
            this.rbtnErrorEleccion.TabStop = true;
            this.rbtnErrorEleccion.Text = "Error de elección";
            this.rbtnErrorEleccion.UseVisualStyleBackColor = true;
            // 
            // rbtnDesperfecto
            // 
            this.rbtnDesperfecto.AutoSize = true;
            this.rbtnDesperfecto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDesperfecto.ForeColor = System.Drawing.Color.White;
            this.rbtnDesperfecto.Location = new System.Drawing.Point(625, 287);
            this.rbtnDesperfecto.Name = "rbtnDesperfecto";
            this.rbtnDesperfecto.Size = new System.Drawing.Size(140, 28);
            this.rbtnDesperfecto.TabIndex = 99;
            this.rbtnDesperfecto.TabStop = true;
            this.rbtnDesperfecto.Text = "Desperfectos";
            this.rbtnDesperfecto.UseVisualStyleBackColor = true;
            // 
            // FormDevolucionescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1371, 674);
            this.Controls.Add(this.rbtnErrorEleccion);
            this.Controls.Add(this.rbtnDesperfecto);
            this.Controls.Add(this.dgvDevoluciones);
            this.Controls.Add(this.btnCancelarDevolucion);
            this.Controls.Add(this.btnCerrarDevoluciones);
            this.Controls.Add(this.btnRealizarDevoluciones);
            this.Controls.Add(this.txtFacturaDevoluciones);
            this.Controls.Add(this.lblNFacturaDevoluciones);
            this.Controls.Add(this.lblMotivoDevoluciones);
            this.Controls.Add(this.txtDescripcionDevoluciones);
            this.Controls.Add(this.lblDescripcionDevoluciones);
            this.Controls.Add(this.lblDevoluciones);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDevolucionescs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Devolucionescs";
            this.Load += new System.EventHandler(this.FormDevolucionescs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCuentas;
        private System.Windows.Forms.Label lblDevoluciones;
        private System.Windows.Forms.Label lblMotivoDevoluciones;
        private System.Windows.Forms.TextBox txtDescripcionDevoluciones;
        private System.Windows.Forms.Label lblDescripcionDevoluciones;
        private System.Windows.Forms.TextBox txtFacturaDevoluciones;
        private System.Windows.Forms.Label lblNFacturaDevoluciones;
        private System.Windows.Forms.Button btnRealizarDevoluciones;
        private System.Windows.Forms.Button btnCerrarDevoluciones;
        private System.Windows.Forms.Button btnCancelarDevolucion;
        private System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.RadioButton rbtnErrorEleccion;
        private System.Windows.Forms.RadioButton rbtnDesperfecto;
    }
}