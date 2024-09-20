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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            TemaColor.colorBtn(btnAgregarVentas);
            TemaColor.colorBtn(btnCancelarVentas);
            TemaColor.colorBtn(btnCerrarVentas);
            TemaColor.colorBtn(btnRealizarVentas);
            //LBL
            TemaColor.colorLbl(lblCambioVentas);
            TemaColor.colorLbl(lblCantidadVentas);
            TemaColor.colorLbl(lblClienteVentas);
            TemaColor.colorLbl(lblCodigoVentas);
            TemaColor.colorLbl(lblMedicamentoVentas);
            TemaColor.colorLbl(lblRecibidoVentas);
            TemaColor.colorLbl(lblTipoVentas);
            TemaColor.colorLbl(lblVentas);
            //dgv
            TemaColor.colorDataGrid(dgbventas);
            //fondo
            TemaColor.colorFondoVentana(this);
            
        }

        private void btnAgregarVentas_Click(object sender, EventArgs e)
        {
            string medicamento = txtMedicamentoVentas.Text;
            string codigo = txtCodigoVentas.Text;
            string cantidad = txtCantidadVentas.Text;
            string cliente = txtClienteVenta.Text;
            string tipo = cmbTipoVentas.Text;
           
            if(btnAgregarVentas.Text == "Nuevo")
            {
                dgbventas.Rows.Clear();
            }
            else
            {
                if (medicamento == "" || tipo == "" || codigo == "" || cliente == "" || cantidad == "")
                {
                    MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                }
                else
                {
                    try
                    {
                        double total = int.Parse(cantidad) * 1;
                        dgbventas.Rows.Add(codigo, medicamento, cantidad, 1, 1, total);
                        txtMedicamentoVentas.Text = "";
                        txtCodigoVentas.Text = "";
                        txtCantidadVentas.Text = "";
                        cmbTipoVentas.Text = "";

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                        throw;
                    }

                }
            }

            
        }

        private void btnCerrarVentas_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void btnRealizarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                double recibido = double.Parse(txtRecibidoVentas.Text);
                double total = double.Parse(txtTotalVentas.Text);
                double cambio = recibido - total;

                txtCambioVentas.Text = "$ " + cambio;
                btnRealizarVentas.Enabled = false;
                btnAgregarVentas.Text = "Nuevo";
                txtMedicamentoVentas.Enabled = false;
                txtCodigoVentas.Enabled = false;
                txtCantidadVentas.Enabled = false;
                txtClienteVenta.Enabled = false;
                cmbTipoVentas.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                
            }
           

        }

        private void btnCancelarVentas_Click(object sender, EventArgs e)
        {
            txtMedicamentoVentas.Text = "";
            txtCodigoVentas.Text = "";
            txtCantidadVentas.Text = "";
            txtClienteVenta.Text = "";
            cmbTipoVentas.Text = "";
            txtTotalVentas.Text = "";
            txtRecibidoVentas.Text = "";
            dgbventas.Rows.Clear();
        }
    }
}
