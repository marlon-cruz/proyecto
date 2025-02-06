using MySqlConnector;
using Mysqlx.Crud;
using Mysqlx.Cursor;
using proyecto1.Clases;
using proyecto1.Funciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace proyecto1
{
    public partial class FormVentas : Form
    {  
        public string cadena_conexion = "server=localhost;user id=unkcode;password=12345;persistsecurityinfo=False;database=divino_niño";

        //conexiones de funcion de botones
        int [,]cantidadActual = new int[20, 20];
        int [,]cantidadDefaul = new int[20, 20];
        int [,]cantidadesCompra = new int[20, 20];
        int contador = 0;
        private string productoId;
        private string medicamento;

        private string precioCaja;
        private string precioBlister;
        private string precioUnidad;
        //cantidad por defecto
        private string defailtCantCaja;
        private string defailtCantblister;
        private string defailtCantunidad;
        //cantidad actual
        private string CantidadCaja;
        private string Cantidadblister;
        private string Cantidadunidad;
        public FormVentas()
        {
            InitializeComponent();
            //Button
            TemaColor.colorBtn(btnAgregarVentas);
            TemaColor.colorBtn(btnCancelarVentas);
            TemaColor.colorBtn(btnCerrarVentas);
            TemaColor.colorBtn(btnRealizarVentas);
            TemaColor.colorBtn(btnEditarVentas);
            TemaColor.colorBtn(btnFacturacion);

            //LBL
            TemaColor.colorLbl(lblCambioVentas);
            TemaColor.colorLbl(lblCantidadVentas);

            TemaColor.colorLbl(lblCodigoVentas);
            TemaColor.colorLbl(lblMedicamentoVentas);
            TemaColor.colorLbl(lblRecibidoVentas);
            TemaColor.colorLbl(lblTipoVentas);
            TemaColor.colorLbl(lblVentas);
            TemaColor.colorLbl(lblTotal);
            //dgv
            TemaColor.colorDataGrid(dgvVentas);
            //fondo
            TemaColor.colorFondoVentana(this);
            //Textbox
            //TemaColor.colorTextBox(txtCambioVentas);
            TemaColor.colorTextBox(txtCantidadVentas);

            TemaColor.colorTextBox(txtCodigoVentas);
            TemaColor.colorTextBox(txtMedicamentoVentas);
            TemaColor.colorTextBox(txtRecibidoVentas);
            // TemaColor.colorTextBox(txtTotalVentas);

            //ComboBox
            TemaColor.colorCombo(cmbTipoVentas);
        }

        private void btnAgregarVentas_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoVentas.Text;
            string cantidad = txtCantidadVentas.Text;
            string tipo = cmbTipoVentas.Text;

            if (btnAgregarVentas.Text == "Nuevo")
            {
                dgvVentas.Rows.Clear();

                btnEditarVentas.Enabled = true;
                btnCancelarVentas.Enabled = true;
                txtCambioVentas.Text = "0.00";
                txtTotalVentas.Text = "0.00";
                txtRecibidoVentas.Text = "";
                btnAgregarVentas.Text = "Agregar";

                txtMedicamentoVentas.Text = "";
                txtCodigoVentas.Text = "";
                txtCantidadVentas.Text = "";


            }
            else
            {
                if (medicamento == "" || tipo == "" || cantidad == "" || codigo == "")
                {
                    MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
                }
                else
                {
                    try
                    {

                        /*
                            cantidadesCompra[contador, 1] = int.Parse(producto_id);
                            cantidadesCompra[contador, 1] = int.Parse(CantidadCaja);
                            cantidadesCompra[contador, 1] = int.Parse(Cantidadblister);
                            cantidadesCompra[contador, 1] = int.Parse(Cantidadunidad);
                          */
                        // string total = txtTotalVentas.Text;
                        string subTotal;
                        int AcantidadActualizada = 0;
                        bool actualizado = false;
                        bool reaizacion = false;

                        int cantidadActualCaja = cantidadesCompra[contador, 1];
                        int cantidadActualBlister = cantidadesCompra[contador, 2];
                        int cantidadActualUnidad = cantidadesCompra[contador, 3];

                        int unidadesDisminucion = 0;
                        for (int i = 0; i < dgvVentas.Rows.Count; i++)
                        {
                            DataGridViewRow row = dgvVentas.Rows[i];
                            if (tipo == "Caja")
                            {
                                unidadesDisminucion = (int.Parse(cantidad) * cantidadesCompra[i, 5]) * cantidadesCompra[i, 6];
                            }
                            else if (tipo == "Blister")
                            {
                                unidadesDisminucion = int.Parse(cantidad) * cantidadesCompra[i, 6];
                            }
                            else if (tipo == "Unidad")
                            {
                                unidadesDisminucion = int.Parse(cantidad);
                            }

                            cantidadActualUnidad = cantidadesCompra[contador, 3] - unidadesDisminucion;
                            cantidadActualBlister = cantidadActualUnidad - cantidadesCompra[i, 2];
                            cantidadActualCaja = cantidadActualBlister / cantidadesCompra[i, 1];

                            if (cantidadesCompra[contador, 0].ToString() == cantidadesCompra[i, 0].ToString())
                            {
                                cantidadesCompra[contador, 1] = cantidadActualCaja;
                                cantidadesCompra[contador, 2] = cantidadActualBlister;
                                cantidadesCompra[contador, 3] = cantidadActualUnidad;
                            }

                            if (cantidadesCompra[contador, 0].ToString() == cantidadesCompra[i, 0].ToString() && tipo == row.Cells["Tipo"].Value.ToString())
                            {

                                if (cantidadActualUnidad < 0)
                                {
                                    AcantidadActualizada = int.Parse(row.Cells["ColumnaCantidad"].Value.ToString()) + int.Parse(cantidad);
                                    row.Cells["ColumnaCantidad"].Value = AcantidadActualizada;

                                    row.Cells["ColumnaTotal"].Value = double.Parse(row.Cells["ColumnaPrecio"].Value.ToString()) * AcantidadActualizada;
                                    contador++;
                                    actualizado = true;

                                    if (cantidadesCompra[contador, 0].ToString() == cantidadesCompra[i, 0].ToString())
                                    {
                                        cantidadesCompra[i, 1] = cantidadActualCaja;
                                        cantidadesCompra[i, 2] = cantidadActualBlister;
                                        cantidadesCompra[i, 3] = cantidadActualUnidad;
                                    }
                                }
                               

                            }
                        }
                        //Si es un producto nuevo

                        if (tipo == "Caja")
                        {

                            unidadesDisminucion = (int.Parse(cantidad) * cantidadesCompra[contador, 5]) * cantidadesCompra[contador, 6];
                        }
                        else if (tipo == "Blister")
                        {
                            MessageBox.Show(contador.ToString());
                            unidadesDisminucion = int.Parse(cantidad) * cantidadesCompra[contador, 6];
                        }
                        else
                        {
                            unidadesDisminucion = int.Parse(cantidad);
                        }

                        MessageBox.Show(unidadesDisminucion.ToString());
                        MessageBox.Show(cantidadesCompra[contador, 3].ToString());
                       
                        cantidadActualUnidad = cantidadesCompra[contador, 3] - unidadesDisminucion;

                        cantidadActualBlister = cantidadActualUnidad - cantidadesCompra[contador, 2];

                        cantidadActualCaja = cantidadActualBlister / cantidadesCompra[contador, 1];



                        if ((int)cantidadActualUnidad < 0)
                        {
                            MessageBox.Show("La cantidad en stock no es suficiente para realizar esta venta", "Alerta");
                        }
                        else
                        {

                            if (actualizado != true)
                            {
                                if (tipo == "Caja" )
                                {
                                    subTotal = (float.Parse(cantidad) * float.Parse(precioCaja)).ToString();
                                    dgvVentas.Rows.Add(codigo, medicamento, tipo, cantidad, precioCaja, subTotal);
                                    contador++;

                                }
                                else if (tipo == "Blister")
                                {
                                    subTotal = ((float.Parse(cantidad) * float.Parse(precioBlister))).ToString();
                                    dgvVentas.Rows.Add(codigo, medicamento, tipo, cantidad, precioBlister, subTotal);
                                    contador++;
                                }
                                else
                                {
                                    subTotal = ((float.Parse(cantidad) * float.Parse(precioUnidad))).ToString();
                                    dgvVentas.Rows.Add(codigo, medicamento, tipo, cantidad, precioUnidad, subTotal);
                                    contador++;
                                }
                                
                            }
                            actualizado = false;
                            reaizacion = false;
                        }




                        for (int i = dgvInventarioOpcion.Rows.Count - 1; i >= 0; i--)
                        {
                            dgvInventarioOpcion.Rows.RemoveAt(i);
                        }

                        txtTotalVentas.Text = comprobandoTotal().ToString();
                        txtMedicamentoVentas.Text = "";
                        txtCodigoVentas.Text = "";
                        txtCantidadVentas.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("¡Intentalo otra vez, la cantidad ingresada no es suficiente para esta venta!", "Alerta");

                    }

                }
            }
        }

        private void btnCerrarVentas_Click(object sender, EventArgs e)
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

        private void btnRealizarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                double recibido = double.Parse(txtRecibidoVentas.Text);
                double total = double.Parse(txtTotalVentas.Text);
                double cambio = recibido - total;

                if (cambio < 0)
                {
                    MessageBox.Show("La cantidad ingresada es menor al total a pagar", "Alerta");
                }
                else
                {

                string myInsertQuery = "";
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    int cantidad = 0;
                for (int i = 0; i < dgvVentas.Rows.Count; i++)
                {

                    DataGridViewRow row = dgvVentas.Rows[i];

                        if (row.Cells["Tipo"].Value.ToString() == "Unidad")
                        {
                            MessageBox.Show("Venta unidad");
                            cantidad = int.Parse(row.Cells["ColumnaCantidad"].Value.ToString());

                        }
                        else if (row.Cells["Tipo"].Value.ToString() == "Blister")
                        {
                            MessageBox.Show("Venta blister");
                            cantidad = int.Parse(row.Cells["ColumnaCantidad"].Value.ToString()) * cantidadDefaul[i, 2];

                        }
                        else if (row.Cells["Tipo"].Value.ToString() == "Caja")
                        { 
                            MessageBox.Show("Venta caja");
                            int apoyoBlister = int.Parse(row.Cells["ColumnaCantidad"].Value.ToString()) * cantidadDefaul[i, 2];

                            cantidad = apoyoBlister * cantidadDefaul[i, 3];
                        }

                        int codigo = cantidadActual[i, 0];
                        myInsertQuery += "UPDATE productos SET CUnidad = (CUnidad - " + cantidad.ToString() + ") WHERE IdProducto = " + codigo.ToString() + "; ";


                        //comprobacion de caja
                        int div_blister = (cantidadActual[i, 3] - cantidad) / cantidadDefaul[i, 3];
                        int blister_modificar = div_blister;

                        int div_caja = blister_modificar / cantidadDefaul[i, 2];
                        int caja_modificar = div_caja;
                        if (caja_modificar < cantidadActual[i, 1])
                        {
                            cantidadActual[i, 1] = caja_modificar;
                            myInsertQuery += "UPDATE productos SET CCaja = " + caja_modificar + " WHERE IdProducto = " + codigo.ToString() + "; ";

                        }
                        if (blister_modificar < cantidadActual[i, 2])
                        {
                            cantidadActual[i, 2] = blister_modificar;
                            myInsertQuery += "UPDATE productos SET CBlister = " + blister_modificar + " WHERE IdProducto = " + codigo.ToString() + "; ";

                        }

                        cantidadActual[i, 3] -= cantidad;

                        
                    }
                MessageBox.Show(myInsertQuery);
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                contador = 0;
            }
                txtCambioVentas.Text = "$ " + cambio;
                btnAgregarVentas.Text = "Nuevo";
                btnEditarVentas.Enabled = false;
                btnCancelarVentas.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("¡Intentalo otra vez!", "Alerta");

            }
        }
        
       private void btnCancelarVentas_Click(object sender, EventArgs e)
        {
            txtMedicamentoVentas.Text = "";
            txtCodigoVentas.Text = "";
            txtCantidadVentas.Text = "";
    
            cmbTipoVentas.Text = "";
            txtTotalVentas.Text = "0.00";
            txtRecibidoVentas.Text = "";
            dgvVentas.Rows.Clear();
        }

       

        private void btnEditarVentas_Click(object sender, EventArgs e)
        {
           
        }

        private void txtMedicamentoVentas_KeyUp(object sender, KeyEventArgs e)
        {
            //Agregar las cantidades base
            string query = "SELECT IdProducto,Codigo, Nombre, PreCaja, PreBlister, PreUnidad, CCaja, CBlister, CUnidad,CantCaja,CantBlister,CantUnidad FROM productos WHERE Nombre LIKE @filtro  AND Vencimiento > CURDATE();";
            string filtro = txtMedicamentoVentas.Text;
            using (MySqlConnection connection = new MySqlConnection(cadena_conexion))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar el parámetro 
                        command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna el DataTable al DataGridView
                        dgvInventarioOpcion.DataSource = dataTable;

                        // Opcional: ocultar la columna "IdProducto" si existe
                        if (dgvInventarioOpcion.Columns.Contains("IdProducto"))
                        {
                            dgvInventarioOpcion.Columns["IdProducto"].Visible = false;
                            /*dgvInventarioOpcion.Columns["CantCaja"].Visible = false;
                            dgvInventarioOpcion.Columns["CantBlister"].Visible = false;
                            dgvInventarioOpcion.Columns["CantUnidad"].Visible = false;*/
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvInventarioOpcion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Obtén la fila seleccionada
                DataGridViewRow row = dgvInventarioOpcion.Rows[e.RowIndex];
                // Asigna los valores de la fila seleccionada a los TextBox

                txtCodigoVentas.Text = row.Cells["Codigo"].Value.ToString();
                txtMedicamentoVentas.Text = row.Cells["Nombre"].Value.ToString();
                medicamento = row.Cells["Nombre"].Value.ToString();

               

                //precios
                precioCaja = row.Cells["PreCaja"].Value.ToString();
                precioBlister = row.Cells["PreBlister"].Value.ToString();
                precioUnidad = row.Cells["PreUnidad"].Value.ToString();


                defailtCantCaja = row.Cells["CantCaja"].Value.ToString();
                defailtCantblister = row.Cells["CantBlister"].Value.ToString();
                defailtCantunidad = row.Cells["CantUnidad"].Value.ToString();
                
                //cantidad actual
                CantidadCaja = row.Cells["CCaja"].Value.ToString();
                Cantidadblister = row.Cells["CBlister"].Value.ToString();
                Cantidadunidad = row.Cells["CUnidad"].Value.ToString();
                //cantidad actual de productos
               
                cantidadActual[contador,1] = int.Parse(defailtCantCaja);
                cantidadDefaul[contador,2] = int.Parse(defailtCantblister);
                cantidadDefaul[contador,3] = int.Parse(defailtCantunidad);
                //cantidad base de producto
                cantidadActual[contador,1] = int.Parse(CantidadCaja);
                cantidadActual[contador,2] = int.Parse(Cantidadblister);
                cantidadActual[contador,3] = int.Parse(Cantidadunidad);

                //cantidades compra 
                cantidadesCompra[contador, 0] = int.Parse(row.Cells["IdProducto"].Value.ToString());
                //cantidades actuales
                cantidadesCompra[contador, 1] = int.Parse(CantidadCaja);
                cantidadesCompra[contador, 2] = int.Parse(Cantidadblister);
                cantidadesCompra[contador, 3] = int.Parse(Cantidadunidad);
                //cantidades ingresadas
                cantidadesCompra[contador, 4] = int.Parse(defailtCantCaja);
                cantidadesCompra[contador, 5] = int.Parse(defailtCantblister);
                cantidadesCompra[contador, 6] = int.Parse(defailtCantunidad);

                

            }
            
        }
      
        public double comprobandoTotal()
        {
            double totalPagar = 0;
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                DataGridViewRow row = dgvVentas.Rows[i];

                totalPagar += double.Parse(row.Cells["ColumnaTotal"].Value.ToString());
            }
                return totalPagar;
        }
    }
}
