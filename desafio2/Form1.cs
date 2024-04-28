using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            float prestamo = float.Parse(txtMontodelPrestamos.Text.ToString());
            float interes = float.Parse(txtTasaAnual.Text.ToString()) / 100;
            float PlazoDelCredito = float.Parse(txtPlazodelCredito.Text.ToString()) * 12;
            float cuota1 = interes*prestamo;
           float cuota2 = (float)(1 -Math.Pow(1 + interes, -PlazoDelCredito));

            float cuotaMensual = cuota1/cuota2;
            label6.Text = cuotaMensual.ToString();

        }
    }
}
