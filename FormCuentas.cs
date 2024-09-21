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

        }

        private void btnCerrarCuentas_Click(object sender, EventArgs e)
        {
            FormMenu formMn = new FormMenu();
            formMn.Show();
            this.Close();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {

        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
