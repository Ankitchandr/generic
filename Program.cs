using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeneric
{
    class GenericClass<T>
    {

        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }

   }
    class GenericClass1
    {
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    class GenericClass2
    {
        public void product<T , S>(T msg, S msg1)
        {
            Console.WriteLine("product id :" + msg);
            Console.WriteLine("product name :" + msg1);
        }


    }


        class Program
        { 
        static void Main(string[] args)
        {
            GenericClass<int> obj = new GenericClass<int>(100);
            GenericClass<double> obj3 = new GenericClass<double>(34.3);
            GenericClass<Boolean> obj4 = new GenericClass<Boolean>(true);
            GenericClass<char> obj1 = new GenericClass<char>('A');
            GenericClass<String> obj2 = new GenericClass<string>("Ankit chandra");

            GenericClass1 gen = new GenericClass1();
            gen.show(15);
            gen.show('A');
            gen.show("Generic Method");
            GenericClass2 obj5 = new GenericClass2();
            obj5.product<int,string>(100,"oil");

            Console.Read();
        }
    }
}
