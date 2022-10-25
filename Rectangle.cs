using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_1
{
    class MyClass
    {
        int a;
        int b;
        int c;
        static int s;
        const int d = 14;
        static MyClass() { s = 115; }
        public readonly Guid id = Guid.NewGuid();
        public MyClass() : this(0) { }
        public MyClass(int a, int b) { this.a = a; this.b = b; }
        public MyClass(int c) { a = c; }
        public readonly string str = "Hello, World";

    }

    class MyClass1
    {
        int a { get; set; }
        int b
        {
            set
            {
                b = 10;
            }
        }
        int c = 15;
        int d = 20;

        void method(int c, int d, out int result)
        {
            result = c + d;
        }
        void increment(ref int n)
        {
            n++;
        }
        void task()
        {
            int num = 5;
            increment(ref num);
        }
        private MyClass1() { }
        static int count = 0;
        private MyClass1(int count)
        {
            count++;
        }
        void amount(int count)
        {
            Console.WriteLine("Количество экземпляров: {0}", count);
        }
    }
    class Equal
    {
        public string name { get; set; }
        public int age { get; set; }
        public Equal() : this(" ", 0) { }
        public Equal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object? obj)
        {
            Equal equal_obj = obj as Equal;
            if (equal_obj == null)
            {
                return false;
            }
            return age.Equals(equal_obj.age);
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.age.GetHashCode();
        }

        public override string ToString()
        {
            return "Name: " + name + " Age: " + age;
        }
    }
    public partial class Part{
        int a;
        public void str()
        {
            Console.WriteLine("HELLO");
        }
    }
}
namespace OOP_2_2
{
    internal class Rectangle
    {
        public int a { get; set; } 
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }

        public Rectangle() : this(0, 0, 0, 0) { }    
        public Rectangle(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public int Perimeter(int a, int b, int c, int d)
        {
            int P = a + b + c + d;
            return P;
        }

        public int Area_Square(int a)
        {
            int S;
            S = a * a;
            return S;
        }

        public int Area_Rectangle(int a, int b)
        {
            int S;
            S = a * b;
            return S;
        }

        public double Area_Custom(int a, int b, int c, int d)
        {
            double S, p;
            p = (a + b + c + d) / 2;
            S = Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
            return S;
        }
    }
}
