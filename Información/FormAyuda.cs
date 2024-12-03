using System;
using Mysqlx;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;//Utilizada para enviar un correo
using System.Diagnostics;
using proyecto1.Clases;
using proyecto1.Funciones;
using System.Net;


namespace proyecto1
{
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
            TemaColor.colorFondoVentana(this);
            TemaColor.colorLbl(label1);
            TemaColor.colorLbl(label2);
            TemaColor.colorLbl(label3);
            TemaColor.colorLbl(label4);
            TemaColor.colorLbl(label5);
            TemaColor.colorBtn(btnCerrar);
            TemaColor.colorBtn(btnGuiaUsuario);
            TemaColor.colorBtn(btnCorreo);
            TemaColor.colorBtn(btnTelefono);
        }

        private void FormAyuda_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
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

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            // Especifica el correo del destinatario
            string emailDestinatario = "backend1507@gmail.com"; // Cambia esto por el correo electrónico deseado
            string asunto = ""; // Opcional: el asunto del correo
            string cuerpo = ""; // Opcional: el cuerpo del correo 
                                // Construye la URL mailto (con la información que se enviara)
                                // string mailtoUrl = $"mailto:{emailDestinatario}?subject={Uri.EscapeDataString(asunto)}&body={Uri.EscapeDataString(cuerpo)}"; 
            string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={Uri.EscapeDataString(emailDestinatario)}&su={Uri.EscapeDataString(asunto)}&body={Uri.EscapeDataString(cuerpo)}";
            // Abre Gmail en el navegador predeterminado
            try
            {
                //Utilizamos la clase Process la cual inicia un nuevo proceso (abriendo el navegador predeterminado)
                //ProcessStarInfo proporciona la información que necesita el proceso para iniciar
                Process.Start(new ProcessStartInfo
                {
                    FileName = gmailUrl,
                    //UseShellExecute indica si se debe usar el shell del sistema operativo para iniciar el proceso
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar abrir Gmail: " + ex.Message);
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7839-3245", "Telefono", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     

        private void btnGuiaUsuario_Click(object sender, EventArgs e)
        {
            // Ruta local del archivo
            
            string rutaBase = Application.StartupPath;
            string rutaArchivo = Path.Combine(rutaBase, "Guia usuario", "Guía de Usuario del Software Farmacia Divino Niño.docx");

            // URL del archivo en Google Drive (reemplaza con tu enlace)
            string urlGoogleDrive = @"https://docs.google.com/document/d/1-G_sie9Po7L8qF_S1TXIeM6OfNpvOE7t/edit?usp=drive_link&ouid=103488671676611426711&rtpof=true&sd=true";

            // Verifica si hay conexión a internet
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    // Intenta descargar desde Google Drive
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(urlGoogleDrive, rutaArchivo); // Sobrescribe el archivo local si existe

                    }
                    MessageBox.Show("Archivo descargado desde Google Drive.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al descargar desde Google Drive: " + ex.Message);
                }
            }

            // Si no hay conexión o hubo un error, usa el archivo local
              if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no se encuentra.");
                return;
            }


            // Verifica si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                // Crea un SaveFileDialog para permitir al usuario elegir la ubicación de guardado
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos WORD (.docx)|.docx";
                saveFileDialog.FileName = "Guía de Usuario del Software Farmacia Divino Niño.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                      
                        // Copia el archivo a la ubicación seleccionada por el usuario
                        File.Copy(rutaArchivo, saveFileDialog.FileName, true);
                        MessageBox.Show("Archivo descargado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al descargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo  no se encuentra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
