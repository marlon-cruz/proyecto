using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormDevolucionescs : Form
    {
        public FormDevolucionescs()
        {
            InitializeComponent();
            TemaColor.colorLbl(lblDescripcionDevoluciones);
            TemaColor.colorLbl(lblDevoluciones);
            TemaColor.colorLbl(lblMotivoDevoluciones);
            TemaColor.colorLbl(lblNFacturaDevoluciones);
            TemaColor.colorBtn(btnCerrarDevoluciones);
            TemaColor.colorBtn(btnRealizarDevoluciones);
            TemaColor.colorBtn(btnCancelarDevolucion);
            TemaColor.colorFondoVentana(this);
            //Button
            TemaColor.colorBtn(btnCerrarDevoluciones);
            TemaColor.colorBtn(btnRealizarDevoluciones);
            //Combo
          //  TemaColor.colorCombo(cmbMotivoDevoluciones);
            //Text
            TemaColor.colorTextBox(txtDescripcionDevoluciones);
            TemaColor.colorTextBox(txtFacturaDevoluciones);
            //dgv
           TemaColor.colorDataGrid(dgvDevoluciones);
          
        }

        private void btnCerrarDevoluciones_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();

        }

        private void btnRealizarDevoluciones_Click(object sender, EventArgs e)
        {
            string numeroFactura = txtFacturaDevoluciones.Text;
            string descripcion = txtDescripcionDevoluciones.Text;

            string motivo = rbtnDesperfecto.Checked ? "Desperfecto" : rbtnErrorEleccion.Checked ? "Error de eleccion" : "";

            if (numeroFactura == "" || descripcion == "" || motivo == "")
            {
                MessageBox.Show("¡Ingresa todos los datos!", "Alerta");
            }
            else
            {
                try
                {
                    dgvDevoluciones.Rows.Add(numeroFactura,descripcion,motivo);
                    txtDescripcionDevoluciones.Text = "";
                    txtFacturaDevoluciones.Text = "";
                    rbtnErrorEleccion.Checked = false;
                    rbtnDesperfecto.Checked = false;

                  

                }
                catch (Exception)
                {
                    MessageBox.Show("¡Intentalo otra vez!", "Alerta");

                }

            }

            txtDescripcionDevoluciones.Text = "";
            txtFacturaDevoluciones.Text = "";
           
        }

        private void FormDevolucionescs_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarDevolucion_Click(object sender, EventArgs e)
        {
            txtDescripcionDevoluciones.Text = "";
            txtFacturaDevoluciones.Text = "";
            
        }

       
    }
}
