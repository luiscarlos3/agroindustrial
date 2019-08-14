using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agroindustrial_clase_sellada
{
   public class Leche_Condensada:leche
    {
        public double azucar = 0.7;
        public double saborinzante = 38;

        public Leche_Condensada()
        {

        }

        public Leche_Condensada(double pazucar, double psaborizante) : base(pazucar, psaborizante)
        {
            this.azucar = pazucar;
            this.saborinzante = psaborizante;
        }
       

       public  double proceso_condensado()
        {
            double num1 = 0, num2 = 0, num3=0;
            num1 =litros * azucar;
            num2 = num1 + saborinzante + conservantes;
            num3 = num2 / 5;          

            return Math.Round(num3);

        }

     
     
    }
}
