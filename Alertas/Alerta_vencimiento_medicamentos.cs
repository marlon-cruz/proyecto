using System.Windows.Forms;
using System.Data;
using MySqlConnector;
using System;

namespace proyecto1
{
    public partial class Alerta_vencimiento_medicamentos : Form
    {
        public string cadena_conexion = "server=localhost;user id=unkcode;password=12345;persistsecurityinfo=False;database=divino_niño";
        //conexiones de funcion de botones
        public Alerta_vencimiento_medicamentos()
        {
            InitializeComponent();
            mostrarProximosVencimientos();
        }

        private void mostrarProximosVencimientos()
        {

            string consulta = "SELECT Codigo, Nombre, CCaja, CBlister, CUnidad, Vencimiento FROM productos WHERE Vencimiento <= DATE_ADD(NOW(), INTERVAL 8 DAY);";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "divino_niño");
            dgvInventario.DataSource = ds;
            dgvInventario.DataMember = "divino_niño";


        }
    }
}
