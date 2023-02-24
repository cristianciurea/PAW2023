using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele si prenumele dvs.: ");
            string nume = Console.ReadLine();
            string prenume = Console.ReadLine();
            Console.WriteLine("Numele este {0} si prenumele {1}", nume, prenume);

            int[] v1 = { 1, 2, 3, 4 };
            int[] v2 = new int[4] { 1, 2, 3, 4 };
            for (int i = 0; i < v2.Length; i++)
                Console.WriteLine(v2[i]);
            int[] v3 = v2; //shallow copy
            v2[1] = 10;
            for (int i = 0; i < v3.Length; i++)
                Console.WriteLine(v3[i]);

            int[] v4 = new int[v2.Length]; //deep copy
            for (int i = 0; i < v2.Length; i++)
                v4[i] = v2[i];
            v2[1] = 100;
            for (int i = 0; i < v4.Length; i++)
                Console.WriteLine(v4[i]);

            
            int[] v5 = (int[])v2.Clone();
            v2[1] = 200;
            for (int i = 0; i < v5.Length; i++)
                Console.WriteLine(v5[i]);

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
            Student s4 = new Student(s2);
        }
    }
}
