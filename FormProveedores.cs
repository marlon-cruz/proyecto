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
            string direccion = txtDireccionProveedor.Text;

            if (codigo == "" || nombre =="" || producto == "" || email == "" || telefono == "" || distribuidor == "" || direccion == "")
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
                    txtDireccionProveedor.Text = "";

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
            if(dgbProveedores.RowCount == 1)
            {
                MessageBox.Show("Aun no existen proveedores");
            }
            else
            {
                if (dgbProveedores.SelectedRows.Count > 0)
                {

                    int rowIndex = dgbProveedores.SelectedRows[0].Index;

                    if (MessageBox.Show("¿Estás seguro de eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        dgbProveedores.Rows.RemoveAt(rowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un proveedor a eliminar.");
                }
            }
            
        }


        private void FormProveedores_Load(object sender, EventArgs e)
        {
        }

        private void btnEditarProveedores_Click(object sender, EventArgs e)
        {
            if (dgbProveedores.Enabled == false)
            {
                dgbProveedores.Enabled = true;
                btnEditarProveedores.Text = "Dejar";
            }
            else
            {
                dgbProveedores.Enabled = false;
                btnEditarProveedores.Text = "Editar";
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            int indice = dgbProveedores.RowCount-1;
            string busqueda = txtBuscarProveedor.Text;
            
            if(indice == 0)
            {
                MessageBox.Show("Aun no hay proveedores registrados");
            }
            else
            {
                if (busqueda == "")
                {
                    MessageBox.Show("Por favor, Ingrese un nombre para realizar la busqueda.");
                }
                else
                {
                    for (int i = 0; i < indice; i++)
                    {
                        string dato = Convert.ToString(dgbProveedores.Rows[i].Cells[1].Value);
                        if (dato == busqueda)
                        {

                            DataGridViewRow fila = dgbProveedores.Rows[i];
                            string nombre = fila.Cells["ColumnaNombre"].Value.ToString();
                            string tel = Convert.ToString(fila.Cells["ColumnaTelefono"].Value);
                            MessageBox.Show("Proveedor encontrado\nNombre: " + nombre + "\nTeléfono: " + tel);
                            break;
                        }
                        else if (i == indice-1)
                        {
                            MessageBox.Show("El proveedor " + busqueda + " no se ha encontrado.");
                            break;
                        }
                    }
                }
            }
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void dgbProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
