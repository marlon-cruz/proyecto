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
    public partial class FormProveedores : Form
    {

        public string cadena_conexion = "server=localhost;user id=unkcode;password=12345;persistsecurityinfo=False;database=divino_niño";
        //conexiones de funcion de botones

        public string registro_modificar;

        public FormProveedores()
        {
            InitializeComponent();
            TemaColor.colorBtn(btnAgregarProveedor);
            TemaColor.colorBtn(btnBuscarProveedor);
            TemaColor.colorBtn(btnCerrarProveedor);
            TemaColor.colorBtn(btnEliminarProveedor);
            TemaColor.colorBtn(btnGuardarProveedor);
            TemaColor.colorLbl(lblBuscarProveedor);
            TemaColor.colorLbl(lblcodigoProveedor);
            TemaColor.colorLbl(lblDistribuidorProveedor);
            TemaColor.colorLbl(lblEmailProveedor);
            TemaColor.colorLbl(lblNombreProveedor);
            TemaColor.colorLbl(lblProductoProveedor);
            TemaColor.colorLbl(lblDireccionProveedor);
            TemaColor.colorLbl(lblProveedores);
            TemaColor.colorLbl(lblTelefonoProveedor);
            TemaColor.colorFondoVentana(this);
            TemaColor.colorDataGrid(dgbProveedores);
            //Button
            TemaColor.colorBtn(btnAgregarProveedor);
            TemaColor.colorBtn(btnBuscarProveedor);
            TemaColor.colorBtn(btnCerrarProveedor);
            TemaColor.colorBtn(btnEditarProveedores);
            TemaColor.colorBtn(btnEliminarProveedor);
            TemaColor.colorBtn(btnGuardarProveedor);
            //textbox
            TemaColor.colorTextBox(txtBuscarProveedor);
            TemaColor.colorTextBox(txtCodigoProveedor);
            TemaColor.colorTextBox(txtDistribuidorProveedor);
            TemaColor.colorTextBox(txtEmailProveedor);
            TemaColor.colorTextBox(txtNombreProveedor);
            TemaColor.colorTextBox(txtProductoProveedor);
            TemaColor.colorTextBox(txtTelefonoProveedor);
            TemaColor.colorTextBox(txtDireccionProveedor);

        }

        private void mostrarProveedores()
        {

            string consulta = "select * from proveedores";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "divino_niño");
            dgbProveedores.DataSource = ds;
            dgbProveedores.DataMember = "divino_niño";

            if (dgbProveedores.Columns.Contains("IdProveedor"))
            {
                dgbProveedores.Columns["IdProveedor"].Visible = false;
            }
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }


        //NUEVA FUNCION GUARDAR
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAgregarProveedor.Text == "Nuevo")
                {
                    txtCodigoProveedor.Enabled = true;
                    txtNombreProveedor.Enabled = true;
                    txtDistribuidorProveedor.Enabled = true;
                    txtProductoProveedor.Enabled = true;
                    txtEmailProveedor.Enabled = true;
                    txtTelefonoProveedor.Enabled = true;
                    txtDireccionProveedor.Enabled = true;
                    btnAgregarProveedor.Text = "Guardar";
                }
                else
                {
                    string codigo = txtCodigoProveedor.Text;
                    string nombre = txtNombreProveedor.Text;
                    string distribuidor = txtDistribuidorProveedor.Text;
                    string producto = txtProductoProveedor.Text;
                    string email = txtEmailProveedor.Text;
                    string telefono = txtTelefonoProveedor.Text;
                    string direccion = txtDireccionProveedor.Text;
                   //string rol = cmbRolCuenta.Text;

                    if (codigo == "" || nombre == "" || distribuidor == "" || producto == "" || email == "" || telefono == "" || direccion == "")
                    {
                        MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                    }
                    else
                    {
                        MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                        string myInsertQuery = "INSERT INTO proveedores(Codigo,Nombre,Distribuidor,Producto,Email,Telefono,Dirección) Values(?Codigo,?Nombre,?Distribuidor,?Producto,?Email,?Telefono,?Dirección)";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                        myCommand.Parameters.Add("?Codigo", MySqlDbType.VarChar, 50).Value = txtCodigoProveedor.Text;
                        myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 100).Value = txtNombreProveedor.Text;
                        myCommand.Parameters.Add("?Distribuidor", MySqlDbType.VarChar, 100).Value = txtDistribuidorProveedor.Text;
                        myCommand.Parameters.Add("?Producto", MySqlDbType.VarChar, 100).Value = txtProductoProveedor.Text;
                        myCommand.Parameters.Add("?Email", MySqlDbType.VarChar, 100).Value = txtEmailProveedor.Text;
                        myCommand.Parameters.Add("?Telefono", MySqlDbType.VarChar, 100).Value = txtTelefonoProveedor.Text;
                        myCommand.Parameters.Add("?Dirección", MySqlDbType.VarChar, 100).Value = txtDireccionProveedor.Text;


                        myCommand.Connection = myConnection;
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myCommand.Connection.Close();

                        MessageBox.Show("Proveedor agregada con éxito", "Farmacia Divino Niño - CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mostrarProveedores();

                        codigo = "";
                        nombre = "";
                        distribuidor = "";
                        producto = "";
                        email = "";
                        telefono = "";
                        direccion = "";
                        txtCodigoProveedor.Enabled = false;
                        txtNombreProveedor.Enabled = false;
                        txtDistribuidorProveedor.Enabled = false;
                        txtProductoProveedor.Enabled = false;
                        txtEmailProveedor.Enabled = false;
                        txtTelefonoProveedor.Enabled = false;
                        txtDireccionProveedor.Enabled = false;
                        txtCodigoProveedor.Text = "";
                        txtNombreProveedor.Text = "";
                        txtDistribuidorProveedor.Text = "";
                        txtProductoProveedor.Text = "";
                        txtEmailProveedor.Text = "";
                        txtTelefonoProveedor.Text = "";
                        txtDireccionProveedor.Text = "";
                        btnAgregarProveedor.Text = "Nuevo";
                    }
                }
             }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el registro de proveedores ", " Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreProveedor.Text.Trim() + "?", "Eliminar cuenta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "DELETE FROM proveedores WHERE IdProveedor = " + registro_modificar;
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("Registro eliminado con exito", "Farmacia Divino Niño-Confirmación");
                mostrarProveedores();

            }
        }

        //NUEVA FUNCION CARGAR DATOS 
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            {
                txtCodigoProveedor.Enabled = false;
                txtNombreProveedor.Enabled = false;
                txtDistribuidorProveedor.Enabled = false;
                txtProductoProveedor.Enabled = false;
                txtEmailProveedor.Enabled = false;
                txtTelefonoProveedor.Enabled = false;
                txtDireccionProveedor.Enabled = false;

                try
                {
                    string consulta = "select * from proveedores";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                    System.Data.DataSet ds = new System.Data.DataSet();
                    comando.Fill(ds, "divino_niño");
                    dgbProveedores.DataSource = ds;
                    dgbProveedores.DataMember = "divino_niño";


                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error de conexion", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnEditarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditarProveedores.Text == "Editar")
                {
                    if (
                     txtCodigoProveedor.Text == ""  ||
                    txtNombreProveedor.Text == "" ||
                    txtDistribuidorProveedor.Text == "" ||
                    txtProductoProveedor.Text == "" ||
                    txtEmailProveedor.Text == "" ||
                    txtTelefonoProveedor.Text == "" ||
                    txtTelefonoProveedor.Text == "" ||
                    txtDireccionProveedor.Text == "")
                    {
                        MessageBox.Show("Debe seleccionar una cuenta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        btnEditarProveedores.Text = "Cancelar";
                        txtCodigoProveedor.Enabled = true;
                        txtNombreProveedor.Enabled = true;
                        txtDistribuidorProveedor.Enabled = true;
                        txtProductoProveedor.Enabled = true;
                        txtEmailProveedor.Enabled = true;
                        txtTelefonoProveedor.Enabled = true;
                        txtDireccionProveedor.Enabled = true;
                    }
                }
                else
                {
                    btnEditarProveedores.Text = "Editar";
                    txtCodigoProveedor.Enabled = false;
                    txtNombreProveedor.Enabled = false;
                    txtDistribuidorProveedor.Enabled = false;
                    txtProductoProveedor.Enabled = false;
                    txtEmailProveedor.Enabled = false;
                    txtTelefonoProveedor.Enabled = false;
                    txtDireccionProveedor.Enabled = false;

                    txtCodigoProveedor.Text = "";
                    txtNombreProveedor.Text = "";
                    txtDistribuidorProveedor.Text = "";
                    txtProductoProveedor.Text = "";
                    txtEmailProveedor.Text = "";
                    txtTelefonoProveedor.Text = "";
                    txtDireccionProveedor.Text = "";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar el registro de proveedor: " + ex.Message, "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de ID incorrecto: " + ex.Message, "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM proveedores WHERE Nombre LIKE @filtro OR Codigo LIKE @filtro";

            string filtro = txtBuscarProveedor.Text;
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
                        dgbProveedores.DataSource = dataTable;

                        if (dgbProveedores.Columns.Contains("IdProveedor"))
                        {
                            dgbProveedores.Columns["IdProveedor"].Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void dgbProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("INGRESAR SOLO NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtTelefonoProveedor.Text.Length == 3)
            {
                txtTelefonoProveedor.Text += "-";
            }
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

        private void dgbProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la celda seleccionada no sea un encabezado
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dgbProveedores.Rows[e.RowIndex];
                // Asigna los valores de la fila seleccionada a los TextBox
       
                txtCodigoProveedor.Text = row.Cells["Codigo"].Value.ToString();
                txtNombreProveedor.Text = row.Cells["Nombre"].Value.ToString();
                txtDistribuidorProveedor.Text = row.Cells["Distribuidor"].Value.ToString();
                txtProductoProveedor.Text = row.Cells["Producto"].Value.ToString();
                txtEmailProveedor.Text = row.Cells["Email"].Value.ToString();
                txtTelefonoProveedor.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccionProveedor.Text = row.Cells["Dirección"].Value.ToString();

                registro_modificar = row.Cells["IdProveedor"].Value.ToString();

            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (btnGuardarProveedor.Text == "Actualizar")
            {
                try
                {
                    //GENERA LA CONEXION DE LA BASE DE DATOS
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    //SE CREAN LAS VARIABLES CON STRING LUEGO SEGUIDO CON EL TEXTO CORRELATIVO
                    string cod = txtCodigoProveedor.Text;
                    string nom = txtNombreProveedor.Text;
                    string dist = txtDistribuidorProveedor.Text;
                    string prod = txtProductoProveedor.Text;
                    string email = txtEmailProveedor.Text;
                    string tel = txtTelefonoProveedor.Text;
                    string dic = txtDireccionProveedor.Text;


                    //EN ESTA LINEA PRESENTA LO QUJE ES LA ACTUALIZANCION DE TODOS LOS DATOS DE LA TABLA DE LA BASE DE DATOS
                    string myInsertQuery = "UPDATE proveedores SET " + "Codigo = '" + cod + "', " + "Nombre = '" + nom + "', " + "Distribuidor = '" + dist + "', " + "Producto = '" + prod + "', " + "Email = '" + email + "', " + "Telefono = '" + tel + "', " + "Dirección = '" + dic + "' " + "WHERE IdProveedor = '" + registro_modificar + "'";

                    //GENERA UNA CADENA DE COMANDOS
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);


                    //INICIA Y CIERRA LA CONEXION COMO SEA INDICADA
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    //MENSAJE DE COMPROBACION PARA VERIFICAR QUE SI FUE GUARDADO EL DATO.
                    MessageBox.Show("Registro de Proveedores actualizado con éxito", "Farmacia Divino Niño - CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //GENERAR CONSULTA A LA BASE DE DATOS CON LA TABLA INDICADA

                    string consulta = "select * from proveedores";


                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "divino_niño");
                    dgbProveedores.DataSource = ds;
                    dgbProveedores.DataMember = "divino_niño";

                }
                catch (MySqlException)
                {
                    //Y SI NO REALIZA LA CONSULTA MOSTRARA LO QUE ES UN MENSAJE DE ERROR PARA PODER VERIFICAR SI FUE ACTUALIZADO O NO.
                    MessageBox.Show("Error al actualizar el registro de cuentas", "Farmacia Divino Niño- Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                //LUEGO DE INGRESAR LOS DATOS Y SE GUARDAN SE LIMPIAN CON ESTA LINEA DE CODIGO INSERTANDO CADA TEXTBOX
                txtCodigoProveedor.Clear();
                txtNombreProveedor.Clear();
                txtDistribuidorProveedor.Clear();
                txtProductoProveedor.Clear();
                txtEmailProveedor.Clear();
                txtTelefonoProveedor.Clear();
                txtDireccionProveedor.Clear();
                mostrarProveedores();
            }
            else
            {
                btnGuardarProveedor.Text = "Cancelar";
                txtCodigoProveedor.Enabled = false;
                txtNombreProveedor.Enabled = false;
                txtDistribuidorProveedor.Enabled = false;
                txtProductoProveedor.Enabled = false;
                txtEmailProveedor.Enabled = false;
                txtTelefonoProveedor.Enabled = false;
                txtDireccionProveedor.Enabled = false;

                btnGuardarProveedor.Text = "Actualizar";
                btnCerrarProveedor.Text = "Nuevo";
                mostrarProveedores();
            }

        }

        private void txtBuscarProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscarProveedor.Text == "")
            {
                mostrarProveedores();
            }
        }
    }
    
}
