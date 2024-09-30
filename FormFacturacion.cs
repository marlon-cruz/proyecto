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
    public partial class FormFacturacion : Form
    {
        public FormFacturacion()
        {
            InitializeComponent();
            TemaColor.colorFondoVentana(this);
            TemaColor.colorBtn(btnAnterior);
            TemaColor.colorBtn(btnCerrarFacturacion);
            TemaColor.colorBtn(btnCrearFactura);
            TemaColor.colorBtn(btnFacturacion);
            TemaColor.colorBtn(btnSiguiente);
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarFacturacion_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoFacturacion.Text;
            string nombre = txtNombreFacturacion.Text;
            string cantidad = txtCantidadFacturacion.Text;
            string precioUndad = txtPrecioFacturacion.Text;
            string total = txtTotalFactura.Text;


            if (codigo == "" || nombre== "" || cantidad == "" || precioUndad ==""|| total == "")
            {
                MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
            }
            else
            {
                try
                {
                    dgvFacturacion.Rows.Add(codigo,nombre,cantidad,precioUndad,total);
                     txtCodigoFacturacion.Text = "";
                     txtNombreFacturacion.Text = "";
                     txtCantidadFacturacion.Text = "";
                     txtPrecioFacturacion.Text = "";
                     txtTotalFactura.Text = "";


                }
                catch (Exception)
                {
                    MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                    throw;
                }

            }
        }
    }
}
