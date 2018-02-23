using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcollection
{

    class GenericCal<T>
    {

        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine("SUM = " + (d1+d2));
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine("Sub = " + (d1 - d2));
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine("Mul = " + (d1 * d2));
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;

            if (d2==0)
            {
                Console.WriteLine("infinity");

            }
            Console.WriteLine("Div = " + ( d1 / d2));
        }
    }







    class Calculater
    {
        static void Main(string[] args)
        {
            ineligible:
            Console.WriteLine("MENU");
            Console.WriteLine("1.ADD");
            Console.WriteLine("2.SUB");
            Console.WriteLine("3.MUL");
            Console.WriteLine("4.DIV");
            
            GenericCal<object> obj = new GenericCal<object>();

            Console.WriteLine("Input Menu no....");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two number");
             Object i = Convert.ToDecimal(Console.ReadLine());
             Object j = Convert.ToDecimal(Console.ReadLine());
            

            switch (num)
            {
            
                case 1:
                    obj.Add(i,j);
                    break;
                case 2:
                    obj.Sub(i, j);
                    break;
                case 3:
                    obj.Mul(i, j);
                    break;
                case 4:
                    obj.Div(i, j);
                    break;
                default: Console.WriteLine("Incorrect Menu no.Input"); break;
            }
           
           //  obj.Add(k,l);
            Console.ReadLine();
            goto ineligible;

        }
    }
}
