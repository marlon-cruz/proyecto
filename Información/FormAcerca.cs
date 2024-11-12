using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1.Funciones
{
    public partial class FormAcerca : Form
    {
        public FormAcerca()
        {
            InitializeComponent();
            TemaColor.colorFondoVentana(this);
            TemaColor.colorBtn(btnCerrar);
            
        }

        private void FormAcerca_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }
    }
}
