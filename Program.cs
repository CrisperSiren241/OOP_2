using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace OOP_2_1
{
    class Program
    {
        static void Main()
        {
            var new_id = new MyClass();;
            Console.WriteLine(new_id.id);
            var id2 = new MyClass();
            Console.WriteLine(id2.id);  
            Part k = new Part();
            k.str();
            k.str2();
            var obj_1 = new Equal("Mary", 23);
            var obj_2 = new Equal("Tom", 23);
            Console.WriteLine(Object.Equals(obj_1, obj_2));
            Console.WriteLine(obj_1);
        }
    }
}
namespace OOP_2_2
{
    class Program {
        static void Main(string[] args) 
        {
            Console.Write("Введите кол-во четырехугольников = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();   
            Rectangle[] new_obj = new Rectangle[n];

            for(int i = 0; i< n; i++)          
            {                                   
                new_obj[i] = new Rectangle();   
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write("Сторона а(высота) = ");
                new_obj[i].a = int.Parse(Console.ReadLine());
                Console.Write("Сторона b(ширина) = ");
                new_obj[i].b = int.Parse(Console.ReadLine());
                Console.Write("Сторона с(высота) = ");
                new_obj[i].c = int.Parse(Console.ReadLine());
                Console.Write("Сторона d(ширина) = ");
                new_obj[i].d = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            int k =0, l = 0, m =0;
            double[] S_A = new double[10];
            double[] S_B = new double[10];
            double[] S_C = new double[10];
            int[] P_A = new int[10];
            int[] P_B = new int[10];
            int[] P_C = new int[10];
            for (int i = 0; i < n; i++)
            {
                if (new_obj[i].a == new_obj[i].b && new_obj[i].a == new_obj[i].c && new_obj[i].a == new_obj[i].d)
                {
                    S_A[k] = new_obj[i].Area_Square(new_obj[i].a);
                    P_A[k] = new_obj[i].Perimeter(new_obj[i].a, new_obj[i].b, new_obj[i].c, new_obj[i].d);
                    k++;
                }
                if (new_obj[i].a == new_obj[i].c && new_obj[i].b == new_obj[i].d && new_obj[i].a != new_obj[i].b && new_obj[i].a != new_obj[i].d)
                {
                    S_B[l] = new_obj[i].Area_Rectangle(new_obj[i].a, new_obj[i].b);
                    P_B[l] = new_obj[i].Perimeter(new_obj[i].a, new_obj[i].b, new_obj[i].c, new_obj[i].d);
                    l++;
                }
                if (new_obj[i].a != new_obj[i].b && new_obj[i].a != new_obj[i].c && new_obj[i].a != new_obj[i].d)
                {
                    S_C[m] = new_obj[i].Area_Custom(new_obj[i].a, new_obj[i].b, new_obj[i].c, new_obj[i].d);
                    P_C[m] = new_obj[i].Perimeter(new_obj[i].a, new_obj[i].b, new_obj[i].c, new_obj[i].d);
                    m++;
                }
            }
            double MaxValue_S = S_A.Max();
            double MaxValue_R = S_B.Max();
            double MaxValue_C = S_C.Max();
            double MaxValue_SP = P_A.Max();
            double MaxValue_RP = P_B.Max();
            double MaxValue_CP = P_C.Max();
            Console.WriteLine("Кол-во квадратов: {0}", k);
            Console.WriteLine("Кол-во прямоугольников: {0}", l);
            Console.WriteLine("Кол-во произвольных четырехугольников: {0}\n", m);
            Console.WriteLine("Максимальная площадь квадрата: {0}", MaxValue_S);
            Console.WriteLine("Максимальная площадь прямоугольника: {0}", MaxValue_R);
            Console.WriteLine("Максимальная площадь пр. четырехуольника: {0}\n", MaxValue_C);
            Console.WriteLine("Максимальный периметр квадрата: {0}", MaxValue_SP);
            Console.WriteLine("Максимальная периметр прямоугольника: {0}", MaxValue_RP);
            Console.WriteLine("Максимальная периметр пр. четырехуольника: {0}", MaxValue_CP);
        }
    }
}

