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

        //public void method1(string str1, int num1 = 0, string str2)
        //{
        //    Console.WriteLine(str1 + num1 + str2);
        //}
        public void method2(string str1, int num1 = 0, string str2 = "null")
        {
            Console.WriteLine(str1 + num1 + str2);
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            // method
            int a = 3, b = 5;
            Method method = new Method();
            Console.WriteLine(method.add(3.1, 3.14));
            Console.WriteLine();

            Console.WriteLine("before swap : a = {0} b = {1}", a, b);
            method.swap(ref a, ref b);
            Console.WriteLine("after swap  : a = {0} b = {1}",a, b);
            Console.WriteLine();

            method.method2("2", str2: "1");

            // class basic
            Player player1;
            Player player2;

            player1 = new Player();
            player1.TakeDamage(100);
            player1.Status();
            // player2.TakeDamage(100); <= error
            player2 = new Player();
            player2 = player1.DeepCopy();
            player2.Status();
            Console.WriteLine();

            // class advance
            Enemy goblin = new Goblin();
            Enemy dragon = new Dragon();
            Enemy slime = new Slime();

            player1.Hit(goblin);
            player1.Hit(dragon);
            player1.Hit(slime);
        }
    }
}
