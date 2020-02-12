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
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            //Split= divide una cadena en base a un delimitador(patron) y devuelve una matriz
            lblRespuestaSerie.Text ="X=" + objEstadistica.media(txtSerie.Text.Split(','));
        }
    }
}
