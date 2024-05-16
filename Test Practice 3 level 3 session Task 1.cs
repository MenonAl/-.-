using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Practice_3_level_3_session_Task_1
{
    class CustomInt
    {
        // Массив нулей и единиц:
        public bool[] bools = new bool[32];
        // Конструктор:
        public CustomInt(int k)
        {
            for (int i = 0; i < 32; ++i)
            {
                if (k % 2 == 0)
                {
                    bools[i] = false;
                }
                else
                {
                    bools[i] = true;
                }
                k = k / 2;
            }
        }

        // Вывод двоичной записи
        public void custPrint()
        {
            for (int i = 31; i >= 0; --i)
            {
                if (bools[i] == true)
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0 + "\n");
                }
            }
        }

        // Вывод оригинального числа
        public void print()
        {
            int res = 0, h = 1;
            for (int i = 0; i < 32; ++i)
            {
                if (bools[i] == true)
                {
                    res += h;
                }
                h = h * 2;
            }
            Console.WriteLine(res);

        }

        // Метод, который необходимо реализовать:
        public void customMul(CustomInt second)
        {
            int res = 0, h = 1;
            for (int i = 0; i < 32; ++i)
            {
                if (this.bools[i] == true)
                {
                    res += h;
                }
                h = h * 2;
            }
            int res_sec = 0; int h_sec = 1;
            for (int i = 0; i < 32; ++i)
            {
                if (second.bools[i] == true)
                {
                    res_sec += h_sec;
                }
                h_sec = h_sec * 2;
            }
            res = res * res_sec;
            for (int i = 0; i < 32; ++i)
            {
                if (res % 2 == 0)
                {
                    this.bools[i] = false;
                }
                else
                {
                    this.bools[i] = true;
                }
                res = res / 2;
            }
            for (int i = 31; i >= 0; --i)
            {
                if (bools[i] == true)
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0);
                }
            }
            Console.ReadLine();
        }
    }
    internal class Program
    {
       static bool tests0() 
        {
            try 
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            } 
            catch { return false; }
        }
        static bool tests1()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests2()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests3()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests4()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests5()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests6()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests7()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests8()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static bool tests9()
        {
            try
            {
                int p = 71;
                CustomInt l = new CustomInt(p);
                l.print();
                l.custPrint();
                int sec = 123;
                CustomInt second = new CustomInt(sec);
                l.customMul(second);
                return true;
            }
            catch { return false; }
        }
        static void Main(string[] args)
        {

        }
    }
}
