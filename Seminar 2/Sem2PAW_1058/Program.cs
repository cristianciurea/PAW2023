using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1058
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(5, "Azorel", 10.5f);
            Animal a3 = (Animal)a2.Clone();
            a3.Nume = "Grivei";
            Girafa g1 = new Girafa(23, "Sophie", 120, 2, 'F');
            Sarpe s1 = new Sarpe(10, "Kaa", 55, true, 5);

            Console.WriteLine(g1);
            Console.WriteLine(s1);

            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(g1);
            z1.ListaAnimale.Add(s1);

            z1.ListaAnimale.Sort();

            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            Animal a4 = new Animal(22, "Balloo", 250);
            z2.ListaAnimale.Add(a4);

            Console.WriteLine(z2);
            Console.WriteLine(z1);
        }
    }
}
