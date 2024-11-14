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
                    string email = txtEmailProveedor.Text;
                    string telefono = txtTelefonoProveedor.Text;
                    string direccion = txtDireccionProveedor.Text;
                    //  string rol = cmbRolCuenta.Text;

                    if (codigo == "" || nombre == "" || distribuidor == "" || email == "" || telefono == "" || direccion == "")
                    {
                        MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                    }
                    else
                    {
                        MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                        string myInsertQuery = "INSERT INTO proveedores(Codigo,Nombre,Distribuidor,E-Mail,Telefono,Dirección) Values(?Codigo,?Nombre,?Distribuidor,?E-Mail,?Telefono,?Dirección)";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                        myCommand.Parameters.Add("?Codigo", MySqlDbType.VarChar, 50).Value = txtCodigoProveedor.Text;
                        myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 100).Value = txtNombreProveedor.Text;
                        myCommand.Parameters.Add("?Distribuidor", MySqlDbType.VarChar, 100).Value = txtDistribuidorProveedor.Text;
                        myCommand.Parameters.Add("?E-Mail", MySqlDbType.VarChar, 100).Value = txtEmailProveedor.Text;
                        myCommand.Parameters.Add("?Telefono", MySqlDbType.VarChar, 100).Value = txtTelefonoProveedor.Text;
                        myCommand.Parameters.Add("?Dirección", MySqlDbType.VarChar, 100).Value = txtDireccionProveedor.Text;


                        myCommand.Connection = myConnection;
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myCommand.Connection.Close();

                        MessageBox.Show("Cuenta agregado con éxito", "Farmacia Divino Niño - CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string consulta = "select * from proveedores";

                        MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                        MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                        System.Data.DataSet ds = new System.Data.DataSet();
                        da.Fill(ds, "divino_niño");
                        dgbProveedores.DataSource = ds;
                        dgbProveedores.DataMember = "divino_niño";

                        codigo = "";
                        nombre = "";
                        distribuidor = "";
                        email = "";
                        telefono = "";
                        direccion = "";
                        txtCodigoProveedor.Enabled = false;
                        txtNombreProveedor.Enabled = false;
                        txtDistribuidorProveedor.Enabled = false;
                        txtEmailProveedor.Enabled = false;
                        txtTelefonoProveedor.Enabled = false;
                        txtDireccionProveedor.Enabled = false;
                        txtCodigoProveedor.Text = "";
                        txtNombreProveedor.Text = "";
                        txtDistribuidorProveedor.Text = "";
                        txtEmailProveedor.Text = "";
                        txtTelefonoProveedor.Text = "";
                        txtDireccionProveedor.Text = "";
                        btnAgregarProveedor.Text = "Nuevo";
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el registro de usuario", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
           
        }

        //NUEVA FUNCION CARGAR DATOS 
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            {
                txtCodigoProveedor.Enabled = false;
                txtNombreProveedor.Enabled = false;
                txtDistribuidorProveedor.Enabled = false;
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
           
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void dgbProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
