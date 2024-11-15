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
            string consulta = "select * from nombre_cuentas";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "divino_niño");
            dgvCuentas.DataSource = ds;
            dgvCuentas.DataMember = "divino_niño";
            if (dgvCuentas.Columns.Contains("IdCuenta"))
            {
                dgvCuentas.Columns["IdCuenta"].Visible = false;
            }
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
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreCuentas.Text.Trim() + "?", "Eliminar cuenta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "DELETE FROM nombre_cuentas WHERE IdCuenta = " + registro_modificar;
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
                        txtUsuarioCuentas.Enabled = true;
                        txtContraseñaCuentas.Enabled = true;
                    }
                }
                else
                {
                    btnEditarCuenta.Text = "Editar";
                    txtNombreCuentas.Enabled = false;
                    txtUsuarioCuentas.Enabled = false;
                    txtContraseñaCuentas.Enabled = false;
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
                    //GENERA LA CONEXION DE LA BASE DE DATOS
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    //SE CREAN LAS VARIABLES CON STRING LUEGO SEGUIDO CON EL TEXTO CORRELATIVO
                    string nom = txtNombreCuentas.Text;
                    string user = txtUsuarioCuentas.Text;
                    string contra = txtContraseñaCuentas.Text;


                    //EN ESTA LINEA PRESENTA LO QUJE ES LA ACTUALIZANCION DE TODOS LOS DATOS DE LA TABLA DE LA BASE DE DATOS
                    string myInsertQuery = "UPDATE nombre_cuentas SET Nombre = '" + nom + "', Usuario= '" + user + "', Contraseña = '" + contra + "'  WHERE IdCuenta = '" + registro_modificar + "'";


                    //GENERA UNA CADENA DE COMANDOS
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);


                    //INICIA Y CIERRA LA CONEXION COMO SEA INDICADA
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    //MENSAJE DE COMPROBACION PARA VERIFICAR QUE SI FUE GUARDADO EL DATO.
                    MessageBox.Show("Registro de cuentas actualizado con éxito", "Farmacia Divino Niño - CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //GENERAR CONSULTA A LA BASE DE DATOS CON LA TABLA INDICADA

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
                    //Y SI NO REALIZA LA CONSULTA MOSTRARA LO QUE ES UN MENSAJE DE ERROR PARA PODER VERIFICAR SI FUE ACTUALIZADO O NO.
                    MessageBox.Show("Error al actualizar el registro de cuentas", "Farmacia Divino Niño- Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                //LUEGO DE INGRESAR LOS DATOS Y SE GUARDAN SE LIMPIAN CON ESTA LINEA DE CODIGO INSERTANDO CADA TEXTBOX
                txtNombreCuentas.Clear();
                txtUsuarioCuentas.Clear();
                txtContraseñaCuentas.Clear();
                mostrarCuentas();
            }
            else
            {
                btnGuardar.Text = "Cancelar";
                txtNombreCuentas.Enabled = false;
                txtUsuarioCuentas.Enabled = false;
                txtContraseñaCuentas.Enabled = false;
                btnGuardar.Text = "Actualizar";
                btnCrearCuenta.Text = "Nuevo";
                mostrarCuentas();
            }


        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM nombre_cuentas WHERE nombre LIKE @filtro OR usuario LIKE @filtro";

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

                        if (dgvCuentas.Columns.Contains("IdCuenta"))
                        {
                            dgvCuentas.Columns["IdCuenta"].Visible = false;
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
                registro_modificar = row.Cells["IdCuenta"].Value.ToString();

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
    }
    
}
