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
                        btnCrearCuenta.Text = "Nuevo";
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
           
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCuentaCuenta_Click(object sender, EventArgs e)
        {
           

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
    }
}
