using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1058
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele si prenumele: ");
            string nume = Console.ReadLine();
            string prenume = Console.ReadLine();
            Console.WriteLine("Numele este {0} si prenumele este {1}",
                nume, prenume);

            int[] v1 = { 1, 2, 3 };
            int[] v2 = new int[4] { 1, 2, 3, 4 };
            for (int i = 0; i < v2.Length; i++)
                //Console.WriteLine(v2[i]);
                Console.Write("{0} ", v2[i]);

            int[] v3 = v2;
            v2[1] = 100;
            Console.WriteLine();
            for (int i = 0; i < v3.Length; i++)
                Console.Write("{0} ", v3[i]);

            int[] v4 = new int[v2.Length];
            for (int i = 0; i < v2.Length; i++)
                v4[i] = v2[i];
            v2[2] = 200;
            Console.WriteLine();
            for (int i = 0; i < v4.Length; i++)
                Console.Write("{0} ", v4[i]);

            int[] v5 = (int[])v2.Clone();
            v2[2] = 300;
            Console.WriteLine();
            for (int i = 0; i < v5.Length; i++)
                Console.Write("{0} ", v5[i]);

            Console.WriteLine();
            int[,] mat1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            for(int i=0;i<mat1.GetLength(0);i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                    Console.Write("{0} ", mat1[i, j]);
                Console.WriteLine();
            }

            int[][] mat2 = new int[2][];
            mat2[0] = new int[3] { 100, 200, 300 };
            mat2[1] = new int[4] { 400, 500, 600, 700 };
            for (int i = 0; i < mat2.Length; i++)
            {
                for (int j = 0; j < mat2[i].Length; j++)
                    Console.Write("{0} ", mat2[i][j]);
                Console.WriteLine();
            }

            Student s1 = new Student();
            Student s2 = new Student(123, "Gigel", 9.5f);
            Student s3 = s2;
            s3.Nume = "Dorel";
            Student s4 = new Student(s2);
            s1.afisare();
            s2.afisare();
            s3.afisare();
            s4.afisare();
            Console.WriteLine(s1);
            Console.WriteLine(s4);
        }
    }
}
