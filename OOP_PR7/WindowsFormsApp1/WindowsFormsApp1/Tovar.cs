using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Tovar
    {
        public string name_tovar, name_ctrana;
        public int a;
        public double b;

        public Tovar()
        {
            name_ctrana = "";
            name_tovar = "";
            a = 0;//Объем годового импорта
            b = 0;//Стоимость единицы товара
        }
        public Tovar(string new_ctrana,string new_tovar, int new_a,double new_b)
        {
            name_tovar = new_tovar;
            name_ctrana = new_ctrana;
            a = new_a;
            b = new_b;
        }
        public override string ToString()
        {
            return "Товар - "+ name_tovar.ToString()+";"+"  Страна - " + name_ctrana.ToString()+";"+
                "   Объем за год - " + a.ToString()+";"+"   Стоимость ед. - "+ b.ToString();

        }
        
    }
}
