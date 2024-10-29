using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//para hacer la conexión con postgres
using Npgsql;

namespace proyecto1.Clases
{
    internal class Conexion
    {
        //NUEVA CONEXION
        NpgsqlConnection conexion = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd = "Farmacia";
        static String usuario = "postgres";
        static String password = "---";
        static String puerto = "5432";
        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        public NpgsqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Conectado a la base de datos");
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos " + e.ToString() + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }
            //retorna el tipo de dato de la función establecer conexión
            return conexion;
        }

    }
}
