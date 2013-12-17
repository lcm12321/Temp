using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试初阶
{
    class Program
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Dec(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            string str="1,2,3,4,5,6,";
            Console.WriteLine(str.Substring(0,str.Length-1));
            Console.Read();
        }
    }
}
