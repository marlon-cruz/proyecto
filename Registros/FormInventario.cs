using proyecto1.Clases;
using proyecto1.Funciones;
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
            string tipo = Conexion.tipoUsuario;

            if (tipo == "Administrador")
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Close();
            }
            else
            {
                MenuEmpleados formMenu = new MenuEmpleados();
                formMenu.Show();
                this.Close();
            }
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

        private void btnBuscarInventario_Click(object sender, EventArgs e)
        {
            int indice = dgvInventario.RowCount - 1;
            string busqueda = txtBuscarInventario.Text;
            if(indice == 0)
            {
                MessageBox.Show("Aun no hay medicamentos en el inventario");
            }
            else
            {
                if (busqueda == "")
                {
                    MessageBox.Show("Por favor, Ingrese un medicamento para realizar la busqueda.");
                }
                else
                {
                    for (int i = 0; i < indice; i++)
                    {
                        string dato = Convert.ToString(dgvInventario.Rows[i].Cells[1].Value);
                        if (dato == busqueda)
                        {

                            DataGridViewRow fila = dgvInventario.Rows[i];
                            string nombre = fila.Cells["ColumnaNombre"].Value.ToString();
                            string cant = Convert.ToString(fila.Cells["ColumnaCantidad"].Value);
                            string precio = Convert.ToString(fila.Cells["ColumnaPrecio"].Value);
                            string precioDes = Convert.ToString(fila.Cells["ColumnaPDescuento"].Value);
                            string vencimiento = Convert.ToString(fila.Cells["ColumnaVencimiento"].Value);
                            MessageBox.Show("Medicamento encontrado\nNombre: " + nombre + "\ncantidad: " + cant + "\nPrecio: " + precio + "\nPrecio con descuento: " + precioDes + "Vencimiento: " + vencimiento);
                            break;
                        }
                        if (i == indice - 1)
                        {
                            MessageBox.Show("El medicamento " + busqueda + " no se ha encontrado.");
                            break;
                        }
                    }
                }
            }
        }

        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.RowCount == 1)
            {
                MessageBox.Show("Aun no existen medicamentos");
            }
            else
            {
                if (dgvInventario.SelectedRows.Count > 0)
                {

                    int rowIndex = dgvInventario.SelectedRows[0].Index;

                    if (MessageBox.Show("¿Estás seguro de eliminar este medicamento?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        dgvInventario.Rows.RemoveAt(rowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un medicamento a eliminar.");
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Alerta_vencimiento_medicamentos formlong = new Alerta_vencimiento_medicamentos();
            formlong.Show();
            
        }

        private void stockCasiVasioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alerta_cantidad_medicamentos formlong = new alerta_cantidad_medicamentos();
            formlong.Show();
        }
    }
}
