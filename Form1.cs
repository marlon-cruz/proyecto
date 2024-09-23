
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            TemaColor.colorFondoVentana(this);

            TemaColor.colorBtn(btnCerrar);
            TemaColor.colorBtn(btnIniciarSesion);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DateTime HoraActual = DateTime.Now;
            //.Year .Month .Day Toma el año, mes y día actual sin necesidad que se ingrese
            //Estos tienen que ir para no ingresarlos nosotros mismos y solo ingresaremos la hora ya que esa
            //La necesitamos para la condición
            DateTime Manana = new DateTime(HoraActual.Year, HoraActual.Month, HoraActual.Day, 00, 00, 00);
            DateTime Tarde = new DateTime(HoraActual.Year, HoraActual.Month, HoraActual.Day, 12, 00, 00);
            DateTime Noche = new DateTime(HoraActual.Year, HoraActual.Month, HoraActual.Day, 18, 00, 00);
            if (HoraActual >= Manana && HoraActual < Tarde)
            {
                lblBienvenido.Text = "¡Buenos días!"+"\n"+"Bienvenido/a";
            }
            else if (HoraActual >= Tarde && HoraActual < Noche)
            {
                lblBienvenido.Text = "¡Buenas tardes! Bienvenido/a";
            }
            else if (HoraActual >= Noche && HoraActual < Tarde)
            {
                lblBienvenido.Text = "¡Buenas noches! Bienvenido/a";
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Admin" && textContraseña.Text == "123")
            {

                textUsuario.Text = "";
                textContraseña.Text = "";
                this.Hide();
                //this.Close();

                FormMenu form2 = new FormMenu();
                // Cierra el formulario de inicio de sesión
                form2.Show();
                

            }
            else
            {
               // MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                MessageBox.Show("Contraseña o Usuario incorrecta", "¡Intentelo de nuevo!");
                textUsuario.Text = "";
                textContraseña.Text = "";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
             Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
