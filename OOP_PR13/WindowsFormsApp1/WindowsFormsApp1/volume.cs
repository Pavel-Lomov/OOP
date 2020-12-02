using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  abstract public  class Volume
    {
        public double v;

        public Volume (double n_v)
        {
            v = n_v;
        }
        abstract public double Calc();
    }
}
