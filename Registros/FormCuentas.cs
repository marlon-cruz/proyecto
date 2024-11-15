using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 
namespace proyecto1
{
    public partial class FormCuentas : Form
    {
        //conexion de la base de datos

        public string cadena_conexion = "server=localhost;user id=unkcode;password=12345;persistsecurityinfo=False;database=divino_niño";
        //conexiones de funcion de botones
        public string registro_eliminar;

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
            //TemaColor.colorCombo(cmbRolCuenta);
            TemaColor.colorDataGrid(dgvCuentas);

        }
        private void mostrarCuentas()
        {
           //MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
            string consulta = "select * from nombre_cuentas";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "divino_niño");
            dgvCuentas.DataSource = ds;
            dgvCuentas.DataMember = "divino_niño";
        }

        private void FormCuentas_Load(object sender, EventArgs e)
        {

            {
                txtNombreCuentas.Enabled = false;
                txtUsuarioCuentas.Enabled = false;
                txtContraseñaCuentas.Enabled = false;

                try
                {
                    mostrarCuentas();

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error de conexion", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCrearCuenta.Text == "Nuevo")
                {
                    txtNombreCuentas.Enabled = true;
                    txtUsuarioCuentas.Enabled = true;
                    txtContraseñaCuentas.Enabled = true;
                    txtNombreCuentas.Text = "";
                    txtUsuarioCuentas.Text = "";
                    txtContraseñaCuentas.Text = "";
                    btnCrearCuenta.Text = "Guardar";
                    btnGuardar.Text = "Cancelar";
                }
                else
                {
                    btnGuardar.Text = "Guardar";
                    string nombre = txtNombreCuentas.Text;
                    string usuario = txtUsuarioCuentas.Text;
                    string contra = txtContraseñaCuentas.Text;
                    //  string rol = cmbRolCuenta.Text;

                    if (nombre == "" || usuario == "" || contra == "")
                    {
                        MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                    }
                    else
                    {
                        MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                        string myInsertQuery = "INSERT INTO nombre_cuentas(Nombre,Usuario,Contraseña) Values(?Nombre,?Usuario,?Contraseña)";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                        myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 100).Value = txtNombreCuentas.Text;
                        myCommand.Parameters.Add("?Usuario", MySqlDbType.VarChar, 100).Value = txtUsuarioCuentas.Text;
                        myCommand.Parameters.Add("?Contraseña", MySqlDbType.VarChar, 50).Value = txtContraseñaCuentas.Text;

                        myCommand.Connection = myConnection;
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myCommand.Connection.Close();

                        MessageBox.Show("Cuenta agregado con éxito", "Farmacia Divino Niño - CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarCuentas();

                        nombre = "";
                        usuario = "";
                        contra = "";
                        txtNombreCuentas.Enabled = false;
                        txtUsuarioCuentas.Enabled = false;
                        txtContraseñaCuentas.Enabled = false;
                        txtNombreCuentas.Text = "";
                        txtUsuarioCuentas.Text = "";
                        txtContraseñaCuentas.Text = "";
                        btnCrearCuenta.Text = "Nuevo";
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el registro de usuario", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreCuentas.Text.Trim() + "?", "Eliminar alumnos", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBuscarCuentaCuenta_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditarCuenta.Text == "Editar")
                {
                    btnEditarCuenta.Text = "Cancelar";
                    txtNombreCuentas.Enabled = true;
                    txtUsuarioCuentas.Enabled = true;
                    txtContraseñaCuentas.Enabled = true;
                }
                else
                {
                    btnEditarCuenta.Text = "Editar";
                    txtNombreCuentas.Enabled = false;
                    txtUsuarioCuentas.Enabled = false;
                    txtContraseñaCuentas.Enabled = false;

                    string nom = txtNombreCuentas.Text.ToString();
                    string use = txtUsuarioCuentas.Text.ToString();
                    string conta = txtContraseñaCuentas.Text.ToString();
                    int id = int.Parse(txtBuscar.Text);

                    // Asegúrate de proporcionar tu cadena de conexión correcta
                    string connectionString = "server=localhost;user id=unkcode;password=12345;persistsecurityinfo=False;database=divino_niño";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string myUpdateQuery = "UPDATE nombre_cuentas SET Nombre = ?Nombre, Usuario = ?Usuario, Contraseña = ?Contraseña WHERE IdCuenta = ?IdCuenta";
                        MySqlCommand myCommand = new MySqlCommand(myUpdateQuery, connection);
                        myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 100).Value = nom;
                        myCommand.Parameters.Add("?Usuario", MySqlDbType.VarChar, 100).Value = use;
                        myCommand.Parameters.Add("?Contraseña", MySqlDbType.VarChar, 50).Value = conta;
                        myCommand.Parameters.Add("?IdCuenta", MySqlDbType.Int32).Value = IdCuenta;

                        // Ejecutar el comando de actualización

                        int rowsAffected = myCommand.ExecuteNonQuery();
                       

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para actualizar.");
                        }
                    }
                    mostrarCuentas(); // Asumiendo que esto recarga los datos en el DataGridView
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar el registro de cuentas: " + ex.Message, "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de ID incorrecto: " + ex.Message, "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTON DE GUARDAR CUENTAS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnCrearCuenta.Text == "Guardar")
            {
                btnGuardar.Text = "Cancelar";
                txtNombreCuentas.Enabled = false;
                txtUsuarioCuentas.Enabled = false;
                txtContraseñaCuentas.Enabled = false;
                txtNombreCuentas.Text = "";
                txtUsuarioCuentas.Text = "";
                txtContraseñaCuentas.Text = "";
                btnGuardar.Text = "Guardar";
                mostrarCuentas();

            }
            else
            {
                MessageBox.Show("Estoy en nuevo");
                
            }


        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
           
        
        }

        // Método auxiliar para mostrar datos de la cuenta en controles específicos
      /*  private void mostrarDatosCuentas(DataRow cuentaData)
        {
            // Suponiendo que tienes controles como TextBoxes donde deseas mostrar los datos de la cuenta
            txtNombreCuentas.Text = cuentaData["Nombre"].ToString();
            txtUsuarioCuentas.Text = cuentaData["Usuario"].ToString();
            txtContraseñaCuentas.Text = cuentaData["Contraseña"].ToString();
            // Añade los controles que necesites para mostrar los datos
        }*/
        private void seleccionarCuentasPorNombre()
        {
           
        }

        private void dgvCuentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarCuentasPorNombre();

        }

        //Para seleccionar una cuenta y editarla
        private void dgvCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la celda seleccionada no sea un encabezado
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dgvCuentas.Rows[e.RowIndex];
                // Asigna los valores de la fila seleccionada a los TextBox
                txtNombreCuentas.Text = row.Cells["Nombre"].Value.ToString();
                txtUsuarioCuentas.Text = row.Cells["Usuario"].Value.ToString();
                txtContraseñaCuentas.Text = row.Cells["Contraseña"].Value.ToString();
                //IdCuenta = row.Cells["IdCuenta"].Value = Convert.ToInt32();    
            }
        }

        private void btnCerrarCuentas_Click(object sender, EventArgs e)
        {
            FormMenu formMn = new FormMenu();
            formMn.Show();
            this.Close();
        }
    }
}
