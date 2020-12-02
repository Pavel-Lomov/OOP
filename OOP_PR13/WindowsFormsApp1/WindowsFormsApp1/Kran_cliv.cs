using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class Kran_cliv:Volume
    {
 
        public double n,m;
        public Kran_cliv(double n_v,double n_n,double n_m) : base(n_v)
        {
            n = n_n;
            m = n_m;
        }

        public override double Calc()
        {
            return v/(n-m);
        }
        public override string ToString()
        {
            return "Обьем "+v+" Кран №1 "+ n +" л, слив "+ m +" л";
         
        }
    }
}
