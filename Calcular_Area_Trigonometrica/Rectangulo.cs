using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Trigonometrica
{
    class Rectangulo
    {
        private Double bas = 0;
        private Double altura = 0;

        public Double Bas
        {
            get { return bas; }
            set { bas = value; }
        }

        public Double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

       public Rectangulo ()
        {

        }

        public Rectangulo( Double p_bas, Double p_altura)
       {
           p_bas = bas;
           p_altura = altura;

       }



    }
}
