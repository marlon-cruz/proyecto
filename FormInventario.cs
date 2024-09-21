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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
            //labels
            TemaColor.colorLbl(lblBuscarInventario);
            TemaColor.colorLbl(lblCantidadInventario);
            TemaColor.colorLbl(lblCodigoInventario);
            TemaColor.colorLbl(lblInventario);
            TemaColor.colorLbl(lblNombreInventario);
            TemaColor.colorLbl(lblPdescuentoInventario);
            TemaColor.colorLbl(lblPrecioInventario);
            TemaColor.colorLbl(lblTipoInventario);
            TemaColor.colorLbl(lblVencimintoInventario);
            //Button
            TemaColor.colorBtn(btnBuscarInventario);
            TemaColor.colorBtn(btnCerrarInventario);
            TemaColor.colorBtn(btnEditarInventario);
            TemaColor.colorBtn(btnEliminarInventario);
            TemaColor.colorBtn(btnGuardarInventario);
            TemaColor.colorBtn(btnAgregarInventario);
            //txtbox
            TemaColor.colorTextBox(txtBuscarInventario);
            TemaColor.colorTextBox(txtCantidadInventario);
            TemaColor.colorTextBox(txtCodigoInventario);
            TemaColor.colorTextBox(txtNombreInventario);
            TemaColor.colorTextBox(txtPdescuentoInventario);
            TemaColor.colorTextBox(txtPrecioInventario);
            //combobox
            TemaColor.colorCombo(cmbTipoInventario);
            //Tabla
            TemaColor.colorDataGrid(dgvInventario);
            //fondo
            TemaColor.colorFondoVentana(this);
            //dateTimePicker
            TemaColor.colorDateTimePicker(dtpCalendarioInventario);
        }

        private void dgbInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarInventario_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void btnEditarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Enabled == false)
            {
                dgvInventario.Enabled = true;
                btnEditarInventario.Text = "Dejar";
            }
            else
            {
                dgvInventario.Enabled = false;
                btnEditarInventario.Text = "Editar";
            }
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreInventario.Text;
            string codigo = txtCodigoInventario.Text;
            string cantidad = txtCantidadInventario.Text;
            string precio = txtPrecioInventario.Text;
            string p_descuento = txtPdescuentoInventario.Text;
            string tipo = cmbTipoInventario.Text;
            DateTime vencimiento = dtpCalendarioInventario.Value;

            if (nombre == "" || codigo == "" || precio == "" || cantidad == "" || p_descuento==""||tipo=="")
            {
                MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
            }
            else
            {
                try
                {
                    dgvInventario.Rows.Add(codigo, nombre, cantidad, precio, p_descuento,tipo ,vencimiento);
                    txtNombreInventario.Text = "";
                    txtCodigoInventario.Text = "";
                    txtCantidadInventario.Text = "";
                    txtPrecioInventario.Text = "";
                    txtPdescuentoInventario.Text = "";
                    cmbTipoInventario.Text = "";
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                    
                }
                
            }
           
        }

        private void btnGuardarInventario_Click(object sender, EventArgs e)
        {

        }

        private void FormInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
