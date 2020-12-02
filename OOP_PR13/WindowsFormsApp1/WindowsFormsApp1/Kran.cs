using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class Kran:Volume
    {
        double n;
        public Kran(double n_v, double n_n) : base(n_v)
        {
            n = n_n;
        }

        public override double Calc()
        {
            return v/n;
        }
        public override string ToString()
        {
            return "Обьем "+v+" Кран №1 " +n + " л";
        }
    }
}
