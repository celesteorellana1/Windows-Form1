﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtRendimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDistancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia = double.Parse(TxtDistancia.Text);
            double rendimiento = double.Parse(TxtRendimiento.Text);
            double galones = distancia / rendimiento;
            lblResultado.Text = "Galones Consumidos: " + galones.ToString(); 
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
