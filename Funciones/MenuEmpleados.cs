﻿using proyecto1.Información;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1.Funciones
{
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados()
        {
            InitializeComponent();
            TemaColor.colorFondoVentana(this);
            TemaColor.colorBtn(btnCerrarMenu);
            TemaColor.colorAcerca(btnAcerca);
        }

        private void MenuEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnInventarioMenu_Click(object sender, EventArgs e)
        {
            FormInventario formInvent = new FormInventario();
            formInvent.Show();
            this.Hide();//Cambiar
        }

        private void btnDevolucionesMenu_Click(object sender, EventArgs e)
        {
            FormDevolucionescs formDev = new FormDevolucionescs();
            formDev.Show();
            this.Hide();//Cambiar
        }

        private void btnVentasMenu_Click(object sender, EventArgs e)
        {
            FormVentas formvent = new FormVentas();
            formvent.Show();
            this.Hide();//Cambiar
        }

        private void btnFacturacionMenu_Click(object sender, EventArgs e)
        {
            FormAyuda formAyu = new FormAyuda();
            formAyu.Show();
            this.Hide();//Cambiar
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            Conocenos acerca = new Conocenos();
            acerca.Show();
            this.Hide();//cambiar
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            FormLogin formlong = new FormLogin();
            formlong.Show();
            this.Hide();//Cambiar
        }
    }
}