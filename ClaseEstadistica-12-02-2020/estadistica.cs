﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEstadistica_12_02_2020
{
    class estadistica
    {
         


        public double media(string[] serie )
        {
            double suma = 0;
            foreach (string valor in serie)
            {
                suma += int.Parse(valor);
            }
            return suma / serie.Length;
        }
        
        public double estandar(string[]serie )
        {
            double media_Aritmetica = media(serie),
                suma = 0;
            

            foreach(string valor in serie)
            {
                suma += Math.Pow(double.Parse(valor) - media_Aritmetica, 2);
            }
            return suma / serie.Length;
        }
        public double tipica(string[]serie)
        {
            return Math.Sqrt(estandar(serie));
        }

    }
}
