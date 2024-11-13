using MySql.Data.MySqlClient;
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

        public string cadena_conexion = "server=localhost;user id=marlon;password=12345;persistsecurityinfo=False;database=divino_niño";
        //conexiones de funcion de botones
        public string registro_eliminar;

        //




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
            //  TemaColor.colorCombo(cmbRolCuenta);
            TemaColor.colorDataGrid(dgvCuentas);
            
        }

        private void FormCuentas_Load(object sender, EventArgs e)
        {

            {
                txtNombreCuentas.Enabled = false;
                txtUsuarioCuentas.Enabled = false;
                txtContraseñaCuentas.Enabled = false;


                try
                {
                    string consulta = "select * from nombre_cuentas";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                    System.Data.DataSet ds = new System.Data.DataSet();
                    comando.Fill(ds, "divino_niño");
                    dgvCuentas.DataSource = ds;
                    dgvCuentas.DataMember = "divino_niño";


                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error de conexion", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioCuentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombreCuentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseñaCuentas_TextChanged(object sender, EventArgs e)
        {

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
                    btnCrearCuenta.Text = "Guardar";
                }
                else
                {
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

                        string consulta = "select * from nombre_cuentas";

                        MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                        MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                        System.Data.DataSet ds = new System.Data.DataSet();
                        da.Fill(ds, "divino_niño");
                        dgvCuentas.DataSource = ds;
                        dgvCuentas.DataMember = "divino_niño";


                        nombre = "";
                        usuario = "";
                        contra = "";
                        txtNombreCuentas.Enabled = false;
                        txtUsuarioCuentas.Enabled = false;
                        txtContraseñaCuentas.Enabled = false;
                        txtNombreCuentas.Text = "";
                        txtUsuarioCuentas.Text = "";
                        txtContraseñaCuentas.Text = "";
                        btnCrearCuenta.Text = "Crear";
                    }
                }

        }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el registro de usuario", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnCerrarCuentas_Click(object sender, EventArgs e)
        {
            FormMenu formMn = new FormMenu();
            formMn.Show();
            this.Close();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from nombre_cuentas Where Codigo = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();



                MessageBox.Show("Registro de cliente eliminado con éxito", "Farmacia divino- CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from nombre_cuentas";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "farmatools_blanqui");
                dgvCuentas.DataSource = ds;
                dgvCuentas.DataMember = "farmatools_blanqui";

                registro_eliminar = txtNombreCuentas.Text;
            }
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCuentaCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "Buscar")
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    // Modifica la consulta para buscar por nombre
                    string myInsertQuery = "SELECT * FROM nombre_cuentas WHERE Nombre LIKE '%" + txtBuscar.Text + "%'";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                    myCommand.Connection = myConnection;
                    myConnection.Open();

                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();

                    if (myReader.Read())
                    {
                        txtNombreCuentas.Text = (myReader.GetString(1));
                        txtUsuarioCuentas.Text = (myReader.GetString(2));
                        txtContraseñaCuentas.Text = (myReader.GetString(3));

                    }
                    else
                    {
                        MessageBox.Show("El registro de cuenta no existe", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    myReader.Close();
                    myConnection.Close();
                    btnBuscarCuenta.Text = "Eliminar";
                }
                else
                {

                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    // Modifica la consulta para buscar y eliminar por el nombre en lugar del ID
                    string myDeleteQuery = "DELETE FROM nombre_cuentas WHERE Nombre = @nombre";
                    MySqlCommand myCommand = new MySqlCommand(myDeleteQuery, myConnection);

                    // Asigna el parámetro para evitar inyecciones SQL
                    myCommand.Parameters.AddWithValue("@nombre", txtBuscar.Text);

                    myConnection.Open();
                    int rowsAffected = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    // Verifica si se eliminó algún registro
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El registro de Cuenta se ha eliminado con éxito", "Farmacia Divino Niño - CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna Cuenta con ese nombre.", "Farmacia Divino Niño - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Actualiza el DataGridView para mostrar los datos actualizados
                    string consulta = "SELECT * FROM nombre_cuenta";
                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "divino_niño");
                    dgvCuentas.DataSource = ds;
                    dgvCuentas.DataMember = "divino_niño";
                    btnBuscarCuenta.Text = "Buscar";
                }



            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de búsqueda está vacío", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    string nom = txtNombreCuentas.Text.ToString();
                    string use = txtUsuarioCuentas.Text.ToString();
                    string conta = txtContraseñaCuentas.Text; ToString();

                    string myInsertQuery = "UPDATE nombre_cuentas SET Nombre = '" + nom + "', Usuario = '" + use + "', Contraseña = '" + conta + "'";

                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);



                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    MessageBox.Show("Registro de cuenta actualizado con éxito", "Farmacia Divino Niño- CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string consulta = "select * from nombre_cuentas";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "divino_niño");
                    dgvCuentas.DataSource = ds;
                    dgvCuentas.DataMember = "divino_niño";

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error al actualizar el registro de cuentas", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //BOTON DE GUARDAR CUENTAS
            private void btnGuardar_Click(object sender, EventArgs e)
        {
            
               
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnBuscarCuenta.Text == "Buscar")
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    // Modifica la consulta para buscar por nombre
                    string myInsertQuery = "SELECT * FROM nombre_cuentas WHERE Nombre LIKE '%" + txtBuscar.Text + "%'";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                    myCommand.Connection = myConnection;
                    myConnection.Open();

                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();

                    if (myReader.Read())
                    {
                        txtNombreCuentas.Text = (myReader.GetString(1));
                        txtUsuarioCuentas.Text = (myReader.GetString(2));
                        txtContraseñaCuentas.Text = (myReader.GetString(3));

                    }
                    else
                    {
                        MessageBox.Show("El registro de cuenta no existe", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    myReader.Close();
                    myConnection.Close();
                    btnBuscarCuenta.Text = "Eliminar";
                }
                else
                {

                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    // Modifica la consulta para buscar y eliminar por el nombre en lugar del ID
                    string myDeleteQuery = "DELETE FROM nombre_cuentas WHERE Nombre = @nombre";
                    MySqlCommand myCommand = new MySqlCommand(myDeleteQuery, myConnection);

                    // Asigna el parámetro para evitar inyecciones SQL
                    myCommand.Parameters.AddWithValue("@nombre", txtBuscar.Text);

                    myConnection.Open();
                    int rowsAffected = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    // Verifica si se eliminó algún registro
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El registro de Cuenta se ha eliminado con éxito", "Farmacia Divino Niño - CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna Cuenta con ese nombre.", "Farmacia Divino Niño - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Actualiza el DataGridView para mostrar los datos actualizados
                    string consulta = "SELECT * FROM nombre_cuenta";
                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "divino_niño");
                    dgvCuentas.DataSource = ds;
                    dgvCuentas.DataMember = "divino_niño";
                    btnBuscarCuenta.Text = "Buscar";
                }



            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de búsqueda está vacío", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
    }

        // Método auxiliar para mostrar datos de la cuenta en controles específicos
        private void mostrarDatosCuentas(DataRow cuentaData)
        {
            // Suponiendo que tienes controles como TextBoxes donde deseas mostrar los datos de la cuenta
            txtNombreCuentas.Text = cuentaData["Nombre"].ToString();
            txtUsuarioCuentas.Text = cuentaData["Usuario"].ToString();
            txtContraseñaCuentas.Text = cuentaData["Contraseña"].ToString();
            // Añade los controles que necesites para mostrar los datos
        }
        private void seleccionarCuentasPorNombre()
        {
            // Configura la cadena de conexión a la base de datos MySQL
            string connectionString = "server=localhost;user id=marlon;password=12345;persistsecurityinfo=False;database=divino_niño";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Obtiene el valor del nombre de la cuenta de la fila seleccionada en el DataGridView
                    var currentRow = dgvCuentas.CurrentRow;
                    if (currentRow != null)
                    {
                        string nombreCuenta = currentRow.Cells["Nombre"].Value.ToString();

                        // Ejecuta una consulta para obtener la información de la cuenta correspondiente
                        string query = "SELECT * FROM nombre_cuentas WHERE nombre = @nombreCuenta";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nombreCuenta", nombreCuenta);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable resultadoTabla = new DataTable();
                        adapter.Fill(resultadoTabla);

                        // Verifica si se encontró algún resultado
                        if (resultadoTabla.Rows.Count > 0)
                        {
                            // Muestra los datos de la cuenta en los controles correspondientes
                            mostrarDatosCuentas(resultadoTabla.Rows[0]);
                        }
                        else
                        {
                            MessageBox.Show("Error: Registro NO encontrado", "Error en la selección de cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Selecciona una cuenta", "Error en la selección de cuentas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       


        private void dgvCuentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarCuentasPorNombre();

        }
    }
}
