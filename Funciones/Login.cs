using MySqlConnector;
using proyecto1.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
           // TemaColor.colorLbl(lblSaludo);
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
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=unkcode;password=12345;database=divino_niño");
                    conn.Open();

                    string query = "SELECT Nombre, Contraseña, TipoUsuario FROM usuariosingreso WHERE Nombre = @Nombre AND Contraseña = @Contraseña";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", textUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", textContraseña.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string tipoUsuario = dt.Rows[0]["TipoUsuario"].ToString();

                        if (tipoUsuario == "Administrador")
                        {
                            MessageBox.Show("BIENVENIDO ADMINISTRADOR", "Farmacia Divino Niño - BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMenu fprincipal = new FormMenu(); // Cambiar por el menú para administrador
                            fprincipal.Show();
                        }
                        else if (tipoUsuario == "Empleado")
                        {
                            MessageBox.Show("BIENVENIDO EMPLEADO", "Farmacia Divino Niño - BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MenuEmpleados fempleado = new MenuEmpleados(); // Cambiar por el menú para empleado
                            fempleado.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textUsuario.Clear();
                        textContraseña.Clear();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsuario.Clear();
                    textContraseña.Clear();
                }
            }
        }
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estas seguro que quieres salir?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            Application.Exit();
        }
    }
}
