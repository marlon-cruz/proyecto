﻿
namespace proyecto1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnCerrarMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevolucionesMenu = new System.Windows.Forms.Button();
            this.btnVentasMenu = new System.Windows.Forms.Button();
            this.btnFacturacionMenu = new System.Windows.Forms.Button();
            this.btnInventarioMenu = new System.Windows.Forms.Button();
            this.btnCuentasMenu = new System.Windows.Forms.Button();
            this.btnProveedoresMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAcerca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarMenu
            // 
            this.btnCerrarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarMenu.Location = new System.Drawing.Point(364, 453);
            this.btnCerrarMenu.Name = "btnCerrarMenu";
            this.btnCerrarMenu.Size = new System.Drawing.Size(150, 43);
            this.btnCerrarMenu.TabIndex = 44;
            this.btnCerrarMenu.Text = "Cerrar";
            this.btnCerrarMenu.UseVisualStyleBackColor = false;
            this.btnCerrarMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(387, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 45);
            this.label1.TabIndex = 43;
            this.label1.Text = "Menú";
            // 
            // btnDevolucionesMenu
            // 
            this.btnDevolucionesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnDevolucionesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolucionesMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDevolucionesMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDevolucionesMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucionesMenu.Image")));
            this.btnDevolucionesMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDevolucionesMenu.Location = new System.Drawing.Point(457, 184);
            this.btnDevolucionesMenu.Name = "btnDevolucionesMenu";
            this.btnDevolucionesMenu.Size = new System.Drawing.Size(156, 115);
            this.btnDevolucionesMenu.TabIndex = 42;
            this.btnDevolucionesMenu.Text = "Devoluciones";
            this.btnDevolucionesMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDevolucionesMenu.UseVisualStyleBackColor = false;
            this.btnDevolucionesMenu.Click += new System.EventHandler(this.btnDevolucionesMenu_Click);
            // 
            // btnVentasMenu
            // 
            this.btnVentasMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnVentasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentasMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnVentasMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVentasMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasMenu.Image")));
            this.btnVentasMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVentasMenu.Location = new System.Drawing.Point(269, 317);
            this.btnVentasMenu.Name = "btnVentasMenu";
            this.btnVentasMenu.Size = new System.Drawing.Size(156, 115);
            this.btnVentasMenu.TabIndex = 41;
            this.btnVentasMenu.Text = "Ventas";
            this.btnVentasMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVentasMenu.UseVisualStyleBackColor = false;
            this.btnVentasMenu.Click += new System.EventHandler(this.btnVentasMenu_Click);
            // 
            // btnFacturacionMenu
            // 
            this.btnFacturacionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnFacturacionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturacionMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFacturacionMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFacturacionMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacionMenu.Image")));
            this.btnFacturacionMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFacturacionMenu.Location = new System.Drawing.Point(457, 317);
            this.btnFacturacionMenu.Name = "btnFacturacionMenu";
            this.btnFacturacionMenu.Size = new System.Drawing.Size(156, 115);
            this.btnFacturacionMenu.TabIndex = 40;
            this.btnFacturacionMenu.Text = "Ayuda";
            this.btnFacturacionMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFacturacionMenu.UseVisualStyleBackColor = false;
            this.btnFacturacionMenu.Click += new System.EventHandler(this.btnFacturacionMenu_Click);
            // 
            // btnInventarioMenu
            // 
            this.btnInventarioMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnInventarioMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventarioMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInventarioMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInventarioMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnInventarioMenu.Image")));
            this.btnInventarioMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInventarioMenu.Location = new System.Drawing.Point(269, 184);
            this.btnInventarioMenu.Name = "btnInventarioMenu";
            this.btnInventarioMenu.Size = new System.Drawing.Size(156, 115);
            this.btnInventarioMenu.TabIndex = 39;
            this.btnInventarioMenu.Text = "Inventario";
            this.btnInventarioMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInventarioMenu.UseVisualStyleBackColor = false;
            this.btnInventarioMenu.Click += new System.EventHandler(this.btnInventarioMenu_Click);
            // 
            // btnCuentasMenu
            // 
            this.btnCuentasMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnCuentasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuentasMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCuentasMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCuentasMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentasMenu.Image")));
            this.btnCuentasMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCuentasMenu.Location = new System.Drawing.Point(269, 53);
            this.btnCuentasMenu.Name = "btnCuentasMenu";
            this.btnCuentasMenu.Size = new System.Drawing.Size(156, 115);
            this.btnCuentasMenu.TabIndex = 38;
            this.btnCuentasMenu.Text = "Cuentas";
            this.btnCuentasMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCuentasMenu.UseVisualStyleBackColor = false;
            this.btnCuentasMenu.Click += new System.EventHandler(this.btnCuentasMenu_Click);
            // 
            // btnProveedoresMenu
            // 
            this.btnProveedoresMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnProveedoresMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProveedoresMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedoresMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProveedoresMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedoresMenu.Image")));
            this.btnProveedoresMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProveedoresMenu.Location = new System.Drawing.Point(457, 53);
            this.btnProveedoresMenu.Name = "btnProveedoresMenu";
            this.btnProveedoresMenu.Size = new System.Drawing.Size(156, 115);
            this.btnProveedoresMenu.TabIndex = 37;
            this.btnProveedoresMenu.Text = "Proveedores";
            this.btnProveedoresMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnProveedoresMenu.UseVisualStyleBackColor = false;
            this.btnProveedoresMenu.Click += new System.EventHandler(this.btnProveedoresMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.Cyan;
            this.btnAcerca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.Location = new System.Drawing.Point(746, 12);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(79, 43);
            this.btnAcerca.TabIndex = 45;
            this.btnAcerca.Text = "?";
            this.btnAcerca.UseVisualStyleBackColor = false;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(837, 503);
            this.Controls.Add(this.btnAcerca);
            this.Controls.Add(this.btnCerrarMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDevolucionesMenu);
            this.Controls.Add(this.btnVentasMenu);
            this.Controls.Add(this.btnFacturacionMenu);
            this.Controls.Add(this.btnInventarioMenu);
            this.Controls.Add(this.btnCuentasMenu);
            this.Controls.Add(this.btnProveedoresMenu);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Divino Niño - Menú";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevolucionesMenu;
        private System.Windows.Forms.Button btnVentasMenu;
        private System.Windows.Forms.Button btnFacturacionMenu;
        private System.Windows.Forms.Button btnInventarioMenu;
        private System.Windows.Forms.Button btnCuentasMenu;
        private System.Windows.Forms.Button btnProveedoresMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAcerca;
    }
}