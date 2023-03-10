using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1058
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(123, 'M', 22, "Gigel", 
                new int[] { 7, 8, 9 });
            Student s3 = (Student)s2.Clone();
            s3 += 10;
            s3 = 10 + s3;
            s3[3] = 1;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine("Anul nasterii lui s2 este {0}", s2.spuneAnNastere());
            Console.WriteLine("Media lui s3 este {0}", (float)s3);

            Student s4 = new Student(456, 'F', 21, "Maricica", 
                new int[] { 10, 10, 10 });

            List<Student> listaStud = new List<Student>();
            //listaStud.Add(s1);
            listaStud.Add(s4);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach (Student s in listaStud)
                Console.WriteLine(s);
        }
    }
}
