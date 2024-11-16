using System;
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
            FormMenu formMn = new FormMenu();
            formMn.Show();
            this.Close();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            { // Especifica el correo del destinatario
              string emailDestinatario = "kevinalexiscastillo14@gmail.com"; // Cambia esto por el correo electrónico deseado
              string asunto = ""; // Opcional: el asunto del correo
              string cuerpo = ""; // Opcional: el cuerpo del correo 
              // Construye la URL mailto (con la información que se enviara)
              // string mailtoUrl = $"mailto:{emailDestinatario}?subject={Uri.EscapeDataString(asunto)}&body={Uri.EscapeDataString(cuerpo)}"; 
             string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={Uri.EscapeDataString(emailDestinatario)}&su={Uri.EscapeDataString(asunto)}&body={Uri.EscapeDataString(cuerpo)}";
                // Abre Gmail en el navegador predeterminado
                try {
               //Utilizamos la clase Process la cual inicia un nuevo proceso (abriendo el navegador predeterminado)
               //ProcessStarInfo proporciona la información que necesita el proceso para iniciar
                    Process.Start(new ProcessStartInfo { 
                        FileName = gmailUrl,
               //UseShellExecute indica si se debe usar el shell del sistema operativo para iniciar el proceso
                        UseShellExecute = true 
                    }); 
                }
                catch (Exception ex) { 
                    MessageBox.Show("Ocurrió un error al intentar abrir Gmail: " + ex.Message); 
                }
            }
        }
    }
}
