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
            TemaColor.colorBtn(btnGuardarInventario);
            //Tabla
            TemaColor.colorDataGrid(dgbInventario);
            //fondo
            TemaColor.colorFondoVentana(this);
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
            if (dgbInventario.Enabled == false)
            {
                dgbInventario.Enabled = true;
                btnEditarInventario.Text = "Dejar";
            }
            else
            {
                dgbInventario.Enabled = false;
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
                    dgbInventario.Rows.Add(codigo, nombre, cantidad, precio, p_descuento,tipo ,vencimiento);
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
    }
}
