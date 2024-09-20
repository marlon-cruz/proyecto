using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormDevolucionescs : Form
    {
        public FormDevolucionescs()
        {
            InitializeComponent();
            TemaColor.colorLbl(lblDescripcionDevoluciones);
            TemaColor.colorLbl(lblDevoluciones);
            TemaColor.colorLbl(lblMotivoDevoluciones);
            TemaColor.colorLbl(lblNFacturaDevoluciones);
            TemaColor.colorBtn(btnCerrarDevoluciones);
            TemaColor.colorBtn(btnRealizarDevoluciones);
            TemaColor.colorFondoVentana(this);
        }

        private void btnCerrarDevoluciones_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();

        }

        private void btnRealizarDevoluciones_Click(object sender, EventArgs e)
        {
            txtDescripcionDevoluciones.Text = "";
            txtFacturaDevoluciones.Text = "";
            cmbMotivoDevoluciones.Text = "";
        }
    }
}
