using MySqlConnector;
using proyecto1.Clases;
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


        private Timer mensajeTimer; // Timer para ocultar el mensaje
        public FormLogin()
        {
            mensajeTimer = new Timer();
            mensajeTimer.Interval = 4000; // 4 segundos
            mensajeTimer.Tick += OcultarMensaje; // Suscribir el evento Tick

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
        public int intentos = 0;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(textUsuario.Text) || string.IsNullOrWhiteSpace(textContraseña.Text))
                {
                    MessageBox.Show("Por favor, completa ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Iniciar conexión
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=unkcode;password=12345;database=divino_niño");
                conn.Open();

                string query = "SELECT Nombre, Usuario, Contraseña, TipoUsuario FROM usuariosingreso WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", textUsuario.Text);
                cmd.Parameters.AddWithValue("@Contraseña", textContraseña.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Verificar si los datos son correctos
                string tipoUsuario = dt.Rows.Count > 0 ? dt.Rows[0]["TipoUsuario"].ToString() : "";

                if (dt.Rows.Count > 0)
                {
                    if (tipoUsuario == "Administrador")
                    {
                        MessageBox.Show("BIENVENIDO ADMINISTRADOR", "Farmacia Divino Niño - BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMenu fprincipal = new FormMenu();
                        fprincipal.Show();
                        this.Hide();//HIDE
                    }
                    else if (tipoUsuario == "Empleado")
                    {
                        MessageBox.Show("BIENVENIDO EMPLEADO", "Farmacia Divino Niño - BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuEmpleados fempleado = new MenuEmpleados();
                        fempleado.Show();
                    }

                    Conexion.tipoUsuario = tipoUsuario;
                    //this.Hide();
                }
                else
                {
                    // Incrementar el contador de intentos
                    intentos++;

                    if (intentos >= 5)
                    {
                        MessageBox.Show("Has alcanzado el límite de intentos fallidos. El programa se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit(); // Cierra la aplicación
                    }
                    else
                    {
                        string mensaje = "Error de usuario o clave de acceso. Intentos restantes: " + (5 - intentos);
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Iniciar temporizador para borrar los campos
                        mensajeTimer.Start();
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsuario.Clear();
                textContraseña.Clear();
            }
        }
    

private void OcultarMensaje(object sender, EventArgs e)
{
    // Detener el temporizador y limpiar los campos
    mensajeTimer.Stop();
    textUsuario.Clear();
    textContraseña.Clear();
}

private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estas seguro que quieres salir?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            Application.Exit();
        }
    }
}
