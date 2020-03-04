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
                double[] longitud = { 1000, 1, 0.01, 0.001, 0.000001, 0.000000001, 1609.34, 0.9144, 0.3048, 0.0254, 0.835905 };
                double Cantidad = double.Parse(txtValor.Text);
                double resultadoFinal;
                int ValorDE = cboLongitudDE.SelectedIndex, ValorA = cboLongitudA.SelectedIndex;
                resultadoFinal = (((longitud[ValorDE]) / (longitud[ValorA])) * (Cantidad));
                lblLongitud.Text = resultadoFinal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        }

    }


