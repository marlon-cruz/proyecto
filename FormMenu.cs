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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            TemaColor.colorFondoVentana(this);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
         
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            FormLogin formlong = new FormLogin();
            formlong.Show();
            this.Close();
        }

        private void btnCuentasMenu_Click(object sender, EventArgs e)
        {
            FormCuentas formCuent = new FormCuentas();
            formCuent.Show();
            this.Close();
        }

        private void btnInventarioMenu_Click(object sender, EventArgs e)
        {
            FormInventario formInvent = new FormInventario();
            formInvent.Show();
            this.Close();
        }

        private void btnVentasMenu_Click(object sender, EventArgs e)
        {
            FormVentas formvent = new FormVentas();
            formvent.Show();
            this.Close();
        }

        private void btnDevolucionesMenu_Click(object sender, EventArgs e)
        {
            FormDevolucionescs formDev = new FormDevolucionescs();
            formDev.Show();
            this.Close();
        }

        private void btnProveedoresMenu_Click(object sender, EventArgs e)
        {
            FormProveedores formprov = new FormProveedores();
            formprov.Show();
            this.Close();
        }

        private void btnFacturacionMenu_Click(object sender, EventArgs e)
        {

            FormFacturacion formfac = new FormFacturacion();
            formfac.Show();
            this.Close();
        }
    }
}
