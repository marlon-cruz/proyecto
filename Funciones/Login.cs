
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
                lblBienvenido.Text = "¡Buenos días! \r\n Bienvenido/a";
            }
            else if (HoraActual >= Tarde && HoraActual <= Noche)
            {
                lblBienvenido.Text = "¡Buenas tardes!  \r\n Bienvenido/a";
            }
            else if (HoraActual >= Noche)
            {
                lblBienvenido.Text = "¡Buenas noches! \r\n Bienvenido/a";
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
        private int i = 0;

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado su usuario" + " ¡Ingrese un usuario!", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textContraseña.Text == "")
            {
                MessageBox.Show("No ha ingresado su contraseña" + " ¡Ingrese una contraseña!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (textUsuario.Text != "Admin")
                {
                    i = i + 1;
                    MessageBox.Show("Este es su intento numero " + i + "\n" + "El usuario ingresado no existe", "¡Intentelo de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textContraseña.Text != "123")
                {
                    i = i + 1;
                    MessageBox.Show("Este es su intento numero " + i + "\n" + "La contraseña ingresado es incorrecta", "¡Intentelo de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textUsuario.Text = "";
                    textContraseña.Text = "";
                    this.Hide();
                    //this.Close();

                    FormMenu form2 = new FormMenu();
                    // Cierra el formulario de inicio de sesión
                    form2.Show();
                }
                if (i >= 5)
                {
                    this.Close();
                }
            }
            
            /*if (textUsuario.Text == "Admin" && textContraseña.Text == "123")
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
                i = i+1;
                MessageBox.Show("Este es su intento numero " + i + "\n" + "Contraseña o Usuario incorrecta", "¡Intentelo de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsuario.Text = "";
                textContraseña.Text = "";
                
            if (i >= 5)
                {
                    this.Close();
                } 
            
            }*/

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

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Conexion objconexion = new Clases.Conexion();
            objconexion.establecerConexion();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {
        }
    }
}
