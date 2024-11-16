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
            //Button
            TemaColor.colorBtn(btnAgregarVentas);
            TemaColor.colorBtn(btnCancelarVentas);
            TemaColor.colorBtn(btnCerrarVentas);
            TemaColor.colorBtn(btnRealizarVentas);
            TemaColor.colorBtn(btnEditarVentas);
            TemaColor.colorBtn(btnFacturacion);
           
            //LBL
            TemaColor.colorLbl(lblCambioVentas);
            TemaColor.colorLbl(lblCantidadVentas);
            TemaColor.colorLbl(lblClienteVentas);
            TemaColor.colorLbl(lblCodigoVentas);
            TemaColor.colorLbl(lblMedicamentoVentas);
            TemaColor.colorLbl(lblRecibidoVentas);
            TemaColor.colorLbl(lblTipoVentas);
            TemaColor.colorLbl(lblVentas);
            TemaColor.colorLbl(lblTotal);
            //dgv
            TemaColor.colorDataGrid(dgvVentas);
            //fondo
            TemaColor.colorFondoVentana(this);
            //Textbox
            //TemaColor.colorTextBox(txtCambioVentas);
            TemaColor.colorTextBox(txtCantidadVentas);
            TemaColor.colorTextBox(txtClienteVenta);
            TemaColor.colorTextBox(txtCodigoVentas);
            TemaColor.colorTextBox(txtMedicamentoVentas);
            TemaColor.colorTextBox(txtRecibidoVentas);
           // TemaColor.colorTextBox(txtTotalVentas);
           
            //ComboBox
            TemaColor.colorCombo(cmbTipoVentas);
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
                dgvVentas.Rows.Clear();

                btnEditarVentas.Enabled = true;
                btnCancelarVentas.Enabled = true;
                txtCambioVentas.Text = "0.00";
                txtTotalVentas.Text = "0.00";
                txtRecibidoVentas.Text = "";
                txtClienteVenta.Text = "";
                btnAgregarVentas.Text = "Agregar";
            }
            else
            {
                if (medicamento == "" || tipo == "" || cliente == "" || cantidad == "" || codigo == "")
                {
                    MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                }
                else
                {
                    try
                    {
                        double total = int.Parse(cantidad) * 2;

                        dgvVentas.Rows.Add(codigo, medicamento, cantidad, 3, 2, total);

                        txtMedicamentoVentas.Text = "";
                        txtCodigoVentas.Text = "";
                        txtCantidadVentas.Text = "";
                        cmbTipoVentas.Text = "";
                        txtCantidadVentas.Text = "";



                        double ventaTotal = double.Parse(txtTotalVentas.Text);
                        ventaTotal += total;
                        txtTotalVentas.Text = ventaTotal.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                   
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

                if(cambio < 0)
                {
                    MessageBox.Show("La cantidad ingresada es menor al total a pagar", "Alerta");
                }
                else
                {
                    txtCambioVentas.Text = "$ " + cambio;
                    btnAgregarVentas.Text = "Nuevo";
                    btnEditarVentas.Enabled = false;
                    btnCancelarVentas.Enabled = false;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                
            }
           

        }

        private void btnCancelarVentas_Click(object sender, EventArgs e)
        {
            txtMedicamentoVentas.Text = "";
           // txtCodigoVentas.Text = "";
            txtCantidadVentas.Text = "";
            txtClienteVenta.Text = "";
            cmbTipoVentas.Text = "";
            txtTotalVentas.Text = "";
            txtRecibidoVentas.Text = "";
            dgvVentas.Rows.Clear();
        }

        private void txtCodigoVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void lblClienteVentas_Click(object sender, EventArgs e)
        {

        }

        private void txtClienteVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarVentas_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Enabled == false)
            {
                dgvVentas.Enabled = true;
                btnEditarVentas.Text = "Dejar";
            }
            else
            {
                dgvVentas.Enabled = false;
                btnEditarVentas.Text = "Editar";
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {

        }
    }
}
