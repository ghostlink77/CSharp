using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTest
{
    class Method
    {
        // Call by Value
        //public void swap(int num1, int num2)
        //{
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //}

        // Call by Reference
        public void swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public int add(int num1, int num2)
        {
            return num1 + num2;
        }
        public double add(double num1, double num2)
        {
            return num1 + num2;
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 3, b = 5;
            Method method = new Method();
            Console.WriteLine(method.add(3.1, 3.14));
            Console.WriteLine();

            Console.WriteLine("before swap : a = {0} b = {1}", a, b);
            method.swap(ref a, ref b);
            Console.WriteLine("after swap  : a = {0} b = {1}",a, b);
        }
    }
}
