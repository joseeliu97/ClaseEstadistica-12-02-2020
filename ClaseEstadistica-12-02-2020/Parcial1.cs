using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseEstadistica_12_02_2020
{
    public partial class Parcial1 : Form
    {
        public Parcial1()
        {
            InitializeComponent();
        }

        private void Parcial1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             
            try
            {
                double[] Divisas = { 1, 0.114285, 0.00898714, 0.014336917, 667.08, 19.36, 39.69, 0.00026 };
                double Cantidad = double.Parse(txtValorDivisas.Text);
                double resultadoFinal;
                int ValorDE = cboDivisasDE.SelectedIndex, ValorA = cboDivisasA.SelectedIndex;
                resultadoFinal = (((Divisas[ValorDE]) / (Divisas[ValorA])) * (Cantidad));
                lblDivisas.Text = resultadoFinal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            try
            {
                double[] Almacenamiento = { 1, 8388608, 1048576, 1024, 0.0009765625, 0.00000095367431660625 };
                double Cantidad = double.Parse(txtValorAlmacenamiento.Text);
                double resultadoFinal;
                int ValorDE = CboAlmacenamientoDE.SelectedIndex, ValorA = CboAlmacenamientoA.SelectedIndex;
                resultadoFinal = (((Almacenamiento[ValorDE]) * (Almacenamiento[ValorA])) / (Cantidad));
                lblAlmacenamiento.Text = resultadoFinal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblAlmacenamiento_Click(object sender, EventArgs e)
        {

        }
    }

    }


