
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
            TemaColor.colorLbl(lblBienvenido);
            TemaColor.colorLbl(lblSaludo);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            //.Year .Month .Day Toma el año, mes y día actual sin necesidad que se ingrese
            //Estos tienen que ir para no ingresarlos nosotros mismos y solo ingresaremos la hora ya que esa
            //La necesitamos para la condición
            DateTime HoraActual = DateTime.Now;
            DateTime Manana = new DateTime(HoraActual.Year, HoraActual.Month, HoraActual.Day, 00, 00, 00);
            DateTime Tarde = new DateTime(HoraActual.Year, HoraActual.Month, HoraActual.Day, 12, 00, 00);
            DateTime Noche = new DateTime(HoraActual.Year, HoraActual.Month, HoraActual.Day, 18, 00, 00);
            if (HoraActual >= Manana && HoraActual <= Tarde)
            {
                lblSaludo.Text = "¡Buenos días!";
            }
            else if (HoraActual >= Tarde && HoraActual <= Noche)
            {
                lblSaludo.Text = "¡Buenas tardes!";
            }
            else if (HoraActual >= Noche)
            {
                lblSaludo.Text = "¡Buenas noches!";
            }
            /*
            else if (HoraActual >= Noche || HoraActual <= Manana)
            {
                lblSaludo.Text = "¡Buenas noches!";
            }
            */
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
                   // MessageBox.Show("Este es su intento numero "+ i +"\n" + "Contraseña o Usuario incorrecta", "¡Intentelo de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // MessageBox.Show("¡Intentalo otra vez!", "Alerta");
                //MessageBoxButtons.OK, MessageBoxIcon.Error agregan un icono al mensaje
                MessageBox.Show("Contraseña o Usuario incorrecta", "¡Intentelo de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}
