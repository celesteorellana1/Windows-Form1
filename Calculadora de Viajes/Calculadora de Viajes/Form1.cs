using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double velocidad = double.Parse(TxtVelocidad.Text);
            double distancia = double.Parse(TxtDestino.Text);
            double tiempo = distancia / velocidad;
            MessageBox.Show("Tiempo estimado de viaje: " + tiempo.ToString() + "horas", "Resultado" );
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
