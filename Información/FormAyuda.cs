using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;//Utilizada para enviar un correo

namespace proyecto1
{
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
            TemaColor.colorFondoVentana(this);
            TemaColor.colorLbl(label1);
            TemaColor.colorLbl(label2);
            TemaColor.colorLbl(label3);
            TemaColor.colorLbl(label4);
            TemaColor.colorLbl(label5);
            TemaColor.colorBtn(btnCerrar);
            TemaColor.colorBtn(btnChat);
            TemaColor.colorBtn(btnCorreo);
            TemaColor.colorBtn(btnTelefono);
        }

        private void FormAyuda_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormMenu formMn = new FormMenu();
            formMn.Show();
            this.Close();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
