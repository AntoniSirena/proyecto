using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Trigonometrica
{
    class Cuadrado
    {
       protected Double val1 = 0;
       protected Double val2 = 0;
       protected Double val3 = 0;
       protected Double val4 = 0;


        public Double Val1
        {
            get { return val1; }
            set { val1 = value; }
        }

        public Double Val2
        {
            get { return val2; }
            set { val2 = value; }
        }
      
        public Double Val3
        {
            get { return val3; }
            set { val3 = value; }
        }
        
        public Double Val4
        {
            get { return val4; }
            set { val4 = value; }
        }


        public Cuadrado ()
        { 
        
        }


       public Cuadrado(Double p_val1, Double p_val2, Double p_val3, Double p_val4)
        {
            val1 = p_val1;
            val2 = p_val2;
            val3 = p_val3;
            val4 = p_val4;
        
        }






    }
}
