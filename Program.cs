using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_2
{
    public class Rectangle
    {
        public int a { get; set; } // Автоматические свойства
        public int b { get; set; }
        public int s { get; set; }

        public Rectangle() : this(0, 0, 0) { }    // Конструктор по умолчанию, если его не добавлять, то придется постоянно вводить параметры при создании экземпляра данного класса
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

            for(int i = 0; i< n; i++)           // Добавлен цикл с инициализацией массива new_obj
            {                                   // Дело в том, что создавая массив объектов, в нем все элементы инизиализированны null
                new_obj[i] = new Rectangle();   // Создаем экземпляр класса с параметрами по умолчанию (конструктор, строка 14)
            }

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

