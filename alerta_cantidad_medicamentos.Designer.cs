namespace proyecto1
{
    partial class alerta_cantidad_medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alerta_cantidad_medicamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxCuentas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 58);
            this.label1.TabIndex = 69;
            this.label1.Text = "Bajos en Stock";
            // 
            // dgvInventario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.ColumnHeadersHeight = 29;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigo,
            this.ColumnaNombre,
            this.ColumnaCantidad,
            this.ColumnaVencimiento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.Enabled = false;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.dgvInventario.Location = new System.Drawing.Point(155, 270);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventario.Size = new System.Drawing.Size(786, 187);
            this.dgvInventario.TabIndex = 67;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaCodigo.HeaderText = "Código";
            this.ColumnaCodigo.MinimumWidth = 6;
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.Width = 103;
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
            this.ColumnaCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.MinimumWidth = 6;
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.Width = 123;
            // 
            // ColumnaVencimiento
            // 
            this.ColumnaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaVencimiento.HeaderText = "Vencimiento";
            this.ColumnaVencimiento.MinimumWidth = 6;
            this.ColumnaVencimiento.Name = "ColumnaVencimiento";
            this.ColumnaVencimiento.Width = 155;
            // 
            // pictureBoxCuentas
            // 
            this.pictureBoxCuentas.Image = global::proyecto1.Properties.Resources.poca_cantidad_en_stock;
            this.pictureBoxCuentas.Location = new System.Drawing.Point(292, -40);
            this.pictureBoxCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCuentas.Name = "pictureBoxCuentas";
            this.pictureBoxCuentas.Size = new System.Drawing.Size(484, 329);
            this.pictureBoxCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentas.TabIndex = 68;
            this.pictureBoxCuentas.TabStop = false;
            // 
            // alerta_cantidad_medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1050, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pictureBoxCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alerta_cantidad_medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Alerta Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCuentas;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVencimiento;
    }
}