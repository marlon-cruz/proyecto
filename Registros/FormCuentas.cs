using MySqlConnector;
using Org.BouncyCastle.Pqc.Crypto.Falcon;
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
    public partial class FormCuentas : Form
    {
        //conexion de la base de datos

        public string cadena_conexion = "server=localhost;user id=unkcode;password=12345;persistsecurityinfo=False;database=divino_niño";
        //conexiones de funcion de botones
        public string registro_eliminar;

        public string registro_modificar;
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
            string consulta = "select * from usuariosingreso";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "divino_niño");
            dgvCuentas.DataSource = ds;
            dgvCuentas.DataMember = "divino_niño";
            if (dgvCuentas.Columns.Contains("Id"))
            {
                dgvCuentas.Columns["Id"].Visible = false;
            }
            if (dgvCuentas.Columns.Contains("Contraseña"))
            {
                dgvCuentas.Columns["Contraseña"].Visible = false;
            }
        }

        private void FormCuentas_Load(object sender, EventArgs e)
        {
            


            {
                txtNombreCuentas.Enabled = false;
                txtUsuarioCuentas.Enabled = false;
                txtContraseñaCuentas.Enabled = false;
                chkAdministrador.Enabled = false;
                chkUsuario.Enabled = false;
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
                    chkAdministrador.Enabled = true;
                    chkUsuario.Enabled = true;
                    txtNombreCuentas.Text = "";
                    txtUsuarioCuentas.Text = "";
                    txtContraseñaCuentas.Text = "";
                    chkAdministrador.Checked = false;
                    chkUsuario.Checked = false;
                    btnCrearCuenta.Text = "Guardar";
                    btnGuardar.Text = "Cancelar";
                }
                else
                {
                    btnGuardar.Text = "Guardar";
                    string nombre = txtNombreCuentas.Text;
                    string usuario = txtUsuarioCuentas.Text;
                    string contra = txtContraseñaCuentas.Text;

                    // Validar que se haya seleccionado un tipo de usuario
                    if (!chkAdministrador.Checked && !chkUsuario.Checked)
                    {
                        MessageBox.Show("¡Selecciona un tipo de usuario!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Determinar el tipo de usuario
                    string tipoUsuario = chkAdministrador.Checked ? "Administrador" : "Empleado";

                    if (nombre == "" || usuario == "" || contra == "")
                    {
                        MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                    }
                    else
                    {
                        MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                        string myInsertQuery = "INSERT INTO usuariosingreso(Nombre,Usuario,Contraseña,TipoUsuario) Values(?Nombre,?Usuario,?Contraseña,?TipoUsuario)";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                        myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 100).Value = txtNombreCuentas.Text;
                        myCommand.Parameters.Add("?Usuario", MySqlDbType.VarChar, 100).Value = txtUsuarioCuentas.Text;
                        myCommand.Parameters.Add("?Contraseña", MySqlDbType.VarChar, 50).Value = txtContraseñaCuentas.Text;
                        myCommand.Parameters.Add("?TipoUsuario", MySqlDbType.VarChar, 50).Value = tipoUsuario;

                        myCommand.Connection = myConnection;
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myCommand.Connection.Close();

                        MessageBox.Show("Cuenta agregada con éxito", "Farmacia Divino Niño - CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarCuentas();

                        nombre = "";
                        usuario = "";
                        contra = "";
                        txtNombreCuentas.Enabled = false;
                        txtUsuarioCuentas.Enabled = false;
                        txtContraseñaCuentas.Enabled = false;
                        chkAdministrador.Enabled = false;
                        chkUsuario.Enabled = false;
                        txtNombreCuentas.Text = "";
                        txtUsuarioCuentas.Text = "";
                        txtContraseñaCuentas.Text = "";
                        chkUsuario.Checked = false;
                        chkAdministrador.Checked = false;
                        chkAdministrador.Checked = false;
                        chkUsuario.Checked = false;
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
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreCuentas.Text.Trim() + "?", "Eliminar cuenta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "DELETE FROM usuariosingreso WHERE Id = " + registro_modificar;
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("Registro eliminado con exito","Farmacia Divino Niño-Confirmación");
                mostrarCuentas();

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
                    if (txtNombreCuentas.Text == "" ||
                       txtUsuarioCuentas.Text == "" ||
                       txtContraseñaCuentas.Text == "")
                    {
                        MessageBox.Show("Debe seleccionar una cuenta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        btnEditarCuenta.Text = "Cancelar";
                        txtNombreCuentas.Enabled = true;
                        //ESTE ES EL DE EMPLEADOS
                        txtUsuarioCuentas.Enabled = true;
                        txtContraseñaCuentas.Enabled = true;
                        chkUsuario.Enabled = true;
                        chkAdministrador.Enabled = true;
                    }
                }
                else
                {
                    btnEditarCuenta.Text = "Editar";
                    txtNombreCuentas.Enabled = false;
                    txtUsuarioCuentas.Enabled = false;
                    txtContraseñaCuentas.Enabled = false;
                    //ESTE ES EL DE EMPLEADOS
                    chkUsuario.Enabled = false;
                    chkAdministrador.Enabled = false;
                    txtNombreCuentas.Text = "";
                    txtUsuarioCuentas.Text = "";
                    txtContraseñaCuentas.Text = "";

                    
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
            if (btnGuardar.Text == "Actualizar")
            {
                try
                {
                    // Genera la conexión de la base de datos
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    // Obtiene los valores de los campos
                    string nom = txtNombreCuentas.Text;
                    string user = txtUsuarioCuentas.Text;
                    string contra = txtContraseñaCuentas.Text;

                    // Validar que los campos no estén vacíos
                    if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(contra))
                    {
                        MessageBox.Show("¡Completa todos los campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar que se haya seleccionado un tipo de usuario
                    if (!chkAdministrador.Checked && !chkUsuario.Checked)
                    {
                        MessageBox.Show("¡Selecciona un tipo de usuario!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Determina el tipo de usuario
                    string tipoUsuario = chkAdministrador.Checked ? "Administrador" : "Empleado";

                    // Consulta para actualizar los datos
                    string myUpdateQuery = "UPDATE usuariosingreso SET Nombre = @Nombre, Usuario = @Usuario, Contraseña = @Contraseña, TipoUsuario = @TipoUsuario WHERE Id = @Id";

                    // Crear y configurar el comando
                    MySqlCommand myCommand = new MySqlCommand(myUpdateQuery);
                    myCommand.Parameters.AddWithValue("@Nombre", nom);
                    myCommand.Parameters.AddWithValue("@Usuario", user);
                    myCommand.Parameters.AddWithValue("@Contraseña", contra);
                    myCommand.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                    myCommand.Parameters.AddWithValue("@Id", registro_modificar); // Id del registro que se está modificando

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    // Mensaje de confirmación
                    MessageBox.Show("Registro de cuentas actualizado con éxito", "Farmacia Divino Niño - CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualiza el DataGridView
                    string consulta = "SELECT * FROM usuariosingreso";
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, myConnection);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "usuariosingreso");
                    dgvCuentas.DataSource = ds.Tables["usuariosingreso"];
                }
                catch (MySqlException ex)
                {
                    // Muestra un mensaje de error
                    MessageBox.Show($"Error al actualizar el registro: {ex.Message}", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Limpia los campos después de actualizar
                txtNombreCuentas.Clear();
                txtUsuarioCuentas.Clear();
                txtContraseñaCuentas.Clear();
                chkAdministrador.Checked = false;
                chkUsuario.Checked = false;

                // Actualiza la lista de cuentas en la tabla
                mostrarCuentas();
            }
            else
            {
                btnGuardar.Text = "Cancelar";
                txtNombreCuentas.Enabled = false;
                txtUsuarioCuentas.Enabled = false;
                txtContraseñaCuentas.Enabled = false;
                chkAdministrador.Enabled = false;
                chkUsuario.Enabled = false;
                btnGuardar.Text = "Actualizar";
                btnCrearCuenta.Text = "Nuevo";
                mostrarCuentas();
            }
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM usuariosingreso WHERE nombre LIKE @filtro OR usuario LIKE @filtro";

            string filtro = txtBuscar.Text;
            using (MySqlConnection connection = new MySqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar el parámetro 
                        command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna el DataTable al DataGridView
                        dgvCuentas.DataSource = dataTable;

                        if (dgvCuentas.Columns.Contains("Id"))
                        {
                            dgvCuentas.Columns["Id"].Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }
               
            

      
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
                string rol = row.Cells["TipoUsuario"].Value.ToString();

                if (rol == "Administrador")
                {
                    chkAdministrador.Checked = true;
                }
                else
                {
                    chkUsuario.Checked = true;
                }
                registro_modificar = row.Cells["Id"].Value.ToString();

            }
        }

        private void btnCerrarCuentas_Click(object sender, EventArgs e)
        {
            FormMenu formMn = new FormMenu();
            formMn.Show();
            this.Close();
        }

        private void txtContraseñaCuentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números (48-57), signos (33-47, 58-64, 91-96, 123-126), y tecla de retroceso
            if (!char.IsDigit(e.KeyChar) &&
                !((e.KeyChar >= 33 && e.KeyChar <= 47) ||
                  (e.KeyChar >= 58 && e.KeyChar <= 64) ||
                  (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                  (e.KeyChar >= 123 && e.KeyChar <= 126)) &&
                e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Bloquear el carácter
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                mostrarCuentas();
            }

        }

        private void chkAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdministrador.Checked)
            {
                chkUsuario.Checked = false;
            }
        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsuario.Checked)
            {
                chkAdministrador.Checked = false;
            }
        }
    }
    
}
