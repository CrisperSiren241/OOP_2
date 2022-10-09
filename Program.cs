using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_2
{
    public class Rectangle
    {
        public int a
        {
            get { return a; }
            set { a = value; }  
        }
        public int b
        {
            get { return b; }
            set { b = value; }
        }
        public int s
        {
            get { return s; }
            set { s = value; }
        }
       public Rectangle(int a, int b, int s)
        {
            this.a = a;
            this.b = b;
            this.s = s;
        }
    }

    class Program {
        static void Main(string[] args) 
        {
            Console.Write("Введите кол-во четырехугольников = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();   
            Rectangle[] new_obj = new Rectangle[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Сторона а = ");
                new_obj[i].a = int.Parse(Console.ReadLine());
                Console.WriteLine("Сторона b = ");
                new_obj[i].b = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("a = {0}\nb = {1}", new_obj[i].a, new_obj[i].b);
            }
        }
    }
}

