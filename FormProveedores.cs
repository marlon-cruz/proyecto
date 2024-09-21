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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            TemaColor.colorBtn(btnAgregarProveedor);
            TemaColor.colorBtn(btnBuscarProveedor);
            TemaColor.colorBtn(btnCerrarProveedor);
            TemaColor.colorBtn(btnEliminarProveedor);
            TemaColor.colorBtn(btnGuardarProveedor);
            TemaColor.colorLbl(lblBuscarProveedor);
            TemaColor.colorLbl(lblcodigoProveedor);
            TemaColor.colorLbl(lblDistribuidorProveedor);
            TemaColor.colorLbl(lblEmailProveedor);
            TemaColor.colorLbl(lblNombreProveedor);
            TemaColor.colorLbl(lblProductoProveedor);
            TemaColor.colorLbl(lblProveedores);
            TemaColor.colorLbl(lblTelefonoProveedor);
            TemaColor.colorFondoVentana(this);
            TemaColor.colorDataGrid(dgbProveedores);
            //Button
            TemaColor.colorBtn(btnAgregarProveedor);
            TemaColor.colorBtn(btnBuscarProveedor);
            TemaColor.colorBtn(btnCerrarProveedor);
            TemaColor.colorBtn(btnEditarProveedores);
            TemaColor.colorBtn(btnEliminarProveedor);
            TemaColor.colorBtn(btnGuardarProveedor);
            //textbox
            TemaColor.colorTextBox(txtBuscarProveedor);
            TemaColor.colorTextBox(txtCodigoProveedor);
            TemaColor.colorTextBox(txtDistribuidorProveedor);
            TemaColor.colorTextBox(txtEmailProveedor);
            TemaColor.colorTextBox(txtNombreProveedor);
            TemaColor.colorTextBox(txtProductoProveedor);
            TemaColor.colorTextBox(txtTelefonoProveedor);
            
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoProveedor.Text;
            string nombre = txtNombreProveedor.Text;
            string distribuidor = txtDistribuidorProveedor.Text;
            string producto = txtProductoProveedor.Text;
            string email = txtEmailProveedor.Text;
            string telefono = txtTelefonoProveedor.Text;

            if (codigo == "" || nombre =="" || producto == "" || email == "" || telefono == "" || distribuidor == "")
            {
                MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
            }
            else
            {
                try
                {
                    dgbProveedores.Rows.Add(codigo,nombre,distribuidor,producto,email,telefono);
                    txtCodigoProveedor.Text ="";
                    txtNombreProveedor.Text = "";
                    txtDistribuidorProveedor.Text = "";
                    txtProductoProveedor.Text = "";
                    txtEmailProveedor.Text = "";
                    txtTelefonoProveedor.Text = "";


                }
                catch (Exception)
                {
                    MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                    throw;
                }

            }

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgbProveedores.Enabled == false)
            {
                dgbProveedores.Enabled = true;
                btnEliminarProveedor.Text = "Dejar";
            }
            else
            {
                dgbProveedores.Enabled = false;
                btnEliminarProveedor.Text = "Editar";
            }
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
