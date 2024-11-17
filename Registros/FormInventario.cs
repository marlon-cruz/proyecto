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
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proyecto1
{
    public partial class FormInventario : Form
    {
        public string cadena_conexion = "server=localhost;user id=unkcode;password=12345;persistsecurityinfo=False;database=divino_niño";
        //conexiones de funcion de botones
        public string registro_modificar;
        public FormInventario()
        {
            InitializeComponent();
            //labels
            TemaColor.colorLbl(lblBuscarInventario);
            TemaColor.colorLbl(lblCantidadInventario);
            TemaColor.colorLbl(lblCodigoInventario);
            TemaColor.colorLbl(lblInventario);
            TemaColor.colorLbl(lblNombreInventario);
            TemaColor.colorLbl(lblArea);
            TemaColor.colorLbl(lblPrecioInventario);
            TemaColor.colorLbl(lblCaja);
            TemaColor.colorLbl(lblUnidad);
            TemaColor.colorLbl(lblBlister);
            TemaColor.colorLbl(lblVencimintoInventario);
            //Button
            TemaColor.colorBtn(btnBuscarInventario);
            TemaColor.colorBtn(btnCerrarInventario);
            TemaColor.colorBtn(btnEditarInventario);
            TemaColor.colorBtn(btnEliminarInventario);
            TemaColor.colorBtn(btnGuardarInventario);
            TemaColor.colorBtn(btnAgregarInventario);
            //txtbox
            TemaColor.colorTextBox(txtBuscarInventario);
            TemaColor.colorTextBox(txtCantidadCaja);
            TemaColor.colorTextBox(txtCodigoInventario);
            TemaColor.colorTextBox(txtNombreInventario);
            TemaColor.colorTextBox(txtCantidadBlister);
            TemaColor.colorTextBox(txtCantidadCaja);
            TemaColor.colorTextBox(txtCantidadUnidad);
            TemaColor.colorTextBox(txtPrecioCaja);
            TemaColor.colorTextBox(txtPrecioBlister);
            TemaColor.colorTextBox(txtPrecioUnidad);
            //combobox
            TemaColor.colorCombo(cmbArea);
            //Tabla
            TemaColor.colorDataGrid(dgvInventario);
            //fondo
            TemaColor.colorFondoVentana(this);
            //dateTimePicker
            TemaColor.colorDateTimePicker(dtpCalendarioInventario);
        }
        private void mostrarInventario()
        {

            string consulta = "select * from productos";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "divino_niño");
            dgvInventario.DataSource = ds;
            dgvInventario.DataMember = "divino_niño";

            if (dgvInventario.Columns.Contains("IdProducto"))
            {
                dgvInventario.Columns["IdProducto"].Visible = false;
            }
        }
        private void dgbInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormInventario_Load(object sender, EventArgs e)
        {
            {

                txtCodigoInventario.Enabled = false;
                txtNombreInventario.Enabled = false;
                cmbArea.Enabled = false;
                txtPrecioCaja.Enabled = false;
                txtPrecioBlister.Enabled = false;
                txtPrecioUnidad.Enabled = false;
                txtCantidadCaja.Enabled = false;
                txtCantidadBlister.Enabled = false;
                txtCantidadUnidad.Enabled = false;
                dtpCalendarioInventario.Enabled = false;

                try
                {
                    mostrarInventario();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error de conexion", "Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void btnCerrarInventario_Click(object sender, EventArgs e)
        {
            string tipo = Conexion.tipoUsuario;

            if (tipo == "Administrador")
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Close();
            }
            else
            {
                MenuEmpleados formMenu = new MenuEmpleados();
                formMenu.Show();
                this.Close();
            }
        }

        private void btnEditarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Enabled == false)
            {
                dgvInventario.Enabled = true;
                btnEditarInventario.Text = "Dejar";
            }
            else
            {
                dgvInventario.Enabled = false;
                btnEditarInventario.Text = "Editar";
            }
        }
        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAgregarInventario.Text == "Nuevo")
                {
                    txtCodigoInventario.Enabled = true;
                    txtNombreInventario.Enabled = true;
                    cmbArea.Enabled = true;
                    txtPrecioCaja.Enabled = true;
                    txtPrecioBlister.Enabled = true;
                    txtPrecioUnidad.Enabled = true;
                    txtCantidadCaja.Enabled = true;
                    txtCantidadBlister.Enabled = true;
                    txtCantidadUnidad.Enabled = true;
                    dtpCalendarioInventario.Enabled = true;
                    btnAgregarInventario.Text = "Guardar";
                }
                else
                {
                    string codigo = txtCodigoInventario.Text;
                    string nombre = txtNombreInventario.Text;
                    string area = cmbArea.Text;
                    string precaja = txtPrecioCaja.Text;//No obligatorio
                    string preblister = txtPrecioBlister.Text;//No obligatorio
                    string preunidad = txtPrecioUnidad.Text;
                    //DateTime fechaingreso = dtpCalendarioInventario.Value;
                    string cancaja = txtCantidadCaja.Text;//No obligatorio
                    string canblister = txtCantidadBlister.Text;//No obligatorio
                    string canunidad = txtCantidadUnidad.Text;
                    
                    //ingreso SERA LA VARIABLE PARA GUARDAR EL INGRESO
                    if (codigo == "" || nombre == "" || area == "" || precaja == "" || preblister == "" || preunidad == "" || cancaja == "" || canblister == "" || canunidad == "")
                    {
                        MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                    }
                    else
                    {
                        DateTime fecha = DateTime.Now;
                        string fechaIngreso = fecha.ToString("yyyy-MM-dd");
                        string vencimiento = dtpCalendarioInventario.Value.ToString("yyyy-MM-dd");

                        MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                        string myInsertQuery = "INSERT INTO productos(Codigo,Nombre,Area,PreCaja,PreBlister,PreUnidad,FechaIngreso,CCaja,CBlister,CUnidad,Vencimiento) Values(?Codigo,?Nombre,?Area,?PreCaja,?PreBlister,?PreUnidad,?FechaIngreso,?CCaja,?CBlister,?CUnidad,?Vencimiento)";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                        myCommand.Parameters.Add("?Codigo", MySqlDbType.VarChar, 50).Value = txtCodigoInventario.Text;
                        myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 100).Value = txtNombreInventario.Text;
                        myCommand.Parameters.Add("?Area", MySqlDbType.VarChar, 100).Value = cmbArea.Text;
                        myCommand.Parameters.Add("?PreCaja", MySqlDbType.Double).Value = txtPrecioCaja.Text;
                        myCommand.Parameters.Add("?PreBlister", MySqlDbType.Double).Value = txtPrecioBlister.Text;
                        myCommand.Parameters.Add("?PreUnidad", MySqlDbType.Double).Value = txtPrecioUnidad.Text;
                        myCommand.Parameters.Add("?FechaIngreso", MySqlDbType.Date).Value = fechaIngreso;
                        myCommand.Parameters.Add("?CCaja", MySqlDbType.Int32, 100).Value = txtCantidadCaja.Text;
                        myCommand.Parameters.Add("?CBlister", MySqlDbType.Int32, 100).Value = txtCantidadBlister.Text;
                        myCommand.Parameters.Add("?CUnidad", MySqlDbType.Int32, 100).Value = txtCantidadUnidad.Text;
                        myCommand.Parameters.Add("?Vencimiento", MySqlDbType.Date).Value = vencimiento;

                        myCommand.Connection = myConnection;
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myCommand.Connection.Close();

                        MessageBox.Show("Producto agregada con éxito", "Farmacia Divino Niño - CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mostrarInventario();
                       
                        codigo = "";
                        nombre = "";
                        area = "";
                        precaja = "";//No obligatorio
                        preblister = "";//No obligatorio
                        preunidad = "";
                        cancaja = "";//No obligatorio
                        canblister = "";//No obligatorio
                        canunidad = "";
                        vencimiento = "";
                        txtCodigoInventario.Enabled = false;
                        txtNombreInventario.Enabled = false;
                        cmbArea.Enabled = false;
                        txtPrecioCaja.Enabled = false;
                        txtPrecioBlister.Enabled = false;
                        txtPrecioUnidad.Enabled = false;
                        txtCantidadCaja.Enabled = false;
                        txtCantidadBlister.Enabled = false;
                        txtCantidadUnidad.Enabled = false;
                        dtpCalendarioInventario.Enabled = false;
                        btnAgregarInventario.Text = "Nuevo";
                        }
                     }
                  }
           catch (MySqlException)
           {
            MessageBox.Show("Ya existe el registro de producto ", " Farmacia Divino Niño - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void btnGuardarInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarInventario_Click(object sender, EventArgs e)
        {
            int indice = dgvInventario.RowCount - 1;
            string busqueda = txtBuscarInventario.Text;
            if(indice == 0)
            {
                MessageBox.Show("Aun no hay medicamentos en el inventario");
            }
            else
            {
                if (busqueda == "")
                {
                    MessageBox.Show("Por favor, Ingrese un medicamento para realizar la busqueda.");
                }
                else
                {
                    for (int i = 0; i < indice; i++)
                    {
                        string dato = Convert.ToString(dgvInventario.Rows[i].Cells[1].Value);
                        if (dato == busqueda)
                        {

                            DataGridViewRow fila = dgvInventario.Rows[i];
                            string nombre = fila.Cells["ColumnaNombre"].Value.ToString();
                            string cant = Convert.ToString(fila.Cells["ColumnaCantidad"].Value);
                            string precio = Convert.ToString(fila.Cells["ColumnaPrecio"].Value);
                            string precioDes = Convert.ToString(fila.Cells["ColumnaPDescuento"].Value);
                            string vencimiento = Convert.ToString(fila.Cells["ColumnaVencimiento"].Value);
                            MessageBox.Show("Medicamento encontrado\nNombre: " + nombre + "\ncantidad: " + cant + "\nPrecio: " + precio + "\nPrecio con descuento: " + precioDes + "Vencimiento: " + vencimiento);
                            break;
                        }
                        if (i == indice - 1)
                        {
                            MessageBox.Show("El medicamento " + busqueda + " no se ha encontrado.");
                            break;
                        }
                    }
                }
            }
        }

        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.RowCount == 1)
            {
                MessageBox.Show("Aun no existen medicamentos");
            }
            else
            {
                if (dgvInventario.SelectedRows.Count > 0)
                {

                    int rowIndex = dgvInventario.SelectedRows[0].Index;

                    if (MessageBox.Show("¿Estás seguro de eliminar este medicamento?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        dgvInventario.Rows.RemoveAt(rowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un medicamento a eliminar.");
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Alerta_vencimiento_medicamentos formlong = new Alerta_vencimiento_medicamentos();
            formlong.Show();
            
        }

        private void stockCasiVasioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alerta_cantidad_medicamentos formlong = new alerta_cantidad_medicamentos();
            formlong.Show();
        }

        private void txtNombreInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //COMEN
            // Verifica que la celda seleccionada no sea un encabezado
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dgvInventario.Rows[e.RowIndex];
                // Asigna los valores de la fila seleccionada a los TextBox

                txtCodigoInventario.Text = row.Cells["Codigo"].Value.ToString();
                txtNombreInventario.Text = row.Cells["Nombre"].Value.ToString();
                cmbArea.Text = row.Cells["Area"].Value.ToString();
                txtPrecioCaja.Text = row.Cells["PreCaja"].Value.ToString();
                txtPrecioBlister.Text = row.Cells["PreBlister"].Value.ToString();
                txtPrecioUnidad.Text = row.Cells["PreUnidad"].Value.ToString();
                //Falta
                txtCantidadCaja.Text = row.Cells["CCaja"].Value.ToString();
                txtCantidadBlister.Text = row.Cells["CBlister"].Value.ToString();
                txtCantidadUnidad.Text = row.Cells["CUnidad"].Value.ToString();
                dtpCalendarioInventario.Text = row.Cells["CInventario"].Value.ToString();
                registro_modificar = row.Cells["IdProducto"].Value.ToString();

            }

        }

        private void txtBuscarInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarInventario.Text == "")
            {
                mostrarInventario();
            }
        }
    }
}
