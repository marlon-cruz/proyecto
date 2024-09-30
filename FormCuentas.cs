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
    public partial class FormCuentas : Form
    {
        public FormCuentas()
        {
            InitializeComponent();

            TemaColor.colorFondoVentana(this);
            //Button
            TemaColor.colorBtn(btnCerrarCuentas);
            TemaColor.colorBtn(btnBuscarCuenta);
            TemaColor.colorBtn(btnCrearCuenta);
            TemaColor.colorBtn(btnEditarCuenta);
            TemaColor.colorBtn(btnEliminarCuenta);
            TemaColor.colorBtn(btnGuardar);
            TemaColor.colorLbl(lblRolCuenta);
            //  TemaColor.colorCombo(cmbRolCuenta);
            
        }

        private void FormCuentas_Load(object sender, EventArgs e)
        {
            
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioCuentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombreCuentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseñaCuentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCuentas.Text;
            string usuario = txtUsuarioCuentas.Text;
            string contra = txtContraseñaCuentas.Text;
            //  string rol = cmbRolCuenta.Text;

            if (nombre == "" || usuario == "" || contra == "" )
            {
                MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
            }
            else
            {
                try
                {
                    dgvCuentas.Rows.Add(nombre, usuario,contra);
                     txtNombreCuentas.Text = "";
                     txtUsuarioCuentas.Text = "";
                     txtContraseñaCuentas.Text ="";
                  //  cmbRolCuenta.Text = "";


                }
                catch (Exception)
                {
                    MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                    throw;
                }

            }
        }

        private void btnCerrarCuentas_Click(object sender, EventArgs e)
        {
            FormMenu formMn = new FormMenu();
            formMn.Show();
            this.Close();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.RowCount == 0)
            {
                MessageBox.Show("Aun no existen cuentas");
            }
            else
            {
                if (dgvCuentas.SelectedRows.Count > 0)
                {

                    int rowIndex = dgvCuentas.SelectedRows[0].Index;

                    if (MessageBox.Show("¿Estás seguro de eliminar esta cuenta?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        dgvCuentas.Rows.RemoveAt(rowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cuenta a eliminar.");
                }
            }
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            int indice = dgvCuentas.RowCount - 1;
            string busqueda = txtBuscar.Text;
            if (indice == dgvCuentas.RowCount)
            {
                MessageBox.Show("Aun no hay ninguna cuenta registrada");
            }
            else
            {
                if (busqueda == "")
                {
                    MessageBox.Show("Por favor, Ingrese un usuario para realizar la busqueda.");
                }
                else
                {
                    for (int i = 0; i <= indice; i++)
                    {
                        string dato = Convert.ToString(dgvCuentas.Rows[i].Cells[1].Value);
                        if (dato == busqueda)
                        {

                            DataGridViewRow fila = dgvCuentas.Rows[i];
                            string nombre = fila.Cells["ColumnaNombre"].Value.ToString();
                            string user = Convert.ToString(fila.Cells["ColumnaUsuario"].Value);
                            MessageBox.Show("Usuario encontrado\nNombre: " + nombre + "\nUsuario: " + user);
                            break;
                        }
                        else if (i == indice)
                        {
                            MessageBox.Show("El usuario " + busqueda + " no se ha encontrado.");
                            break;
                        }
                    }
                }
            }
        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.Enabled == false)
            {
                dgvCuentas.Enabled = true;
                btnEditarCuenta.Text = "Dejar";
            }
            else
            {
                dgvCuentas.Enabled = false;
                btnEditarCuenta.Text = "Editar";
            }
        }
    }
   
}
