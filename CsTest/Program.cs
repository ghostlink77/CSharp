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
        public float add(float num1, float num2)
        {
            return num1 + num2;
        }

    }
    class Program
    {
        public void swap(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        private void Awake()
        {
            int a = 3, b = 4;
            swap(a, b);
        }
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Method method = new Method();


            for (int i = 1; i <= 10; i++) nums[i] = i;
            for (int i = 1; i <= 10; i++) Console.WriteLine(nums[i]);
        }
    }
}
