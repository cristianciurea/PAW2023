using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(12, "Azorica", 10.5f);
            Animal a3 = (Animal)a2.Clone();
            a3.Nume = "Grivei";
            a3 = a3 + 10;
            a3 += 10;
            a3 = a3 + a1.Greutate;
            a3 = a1.Greutate + a3;

            Pasare p1 = new Pasare(5, "Dodo", 8.3f, "papagal",
                "galben");
            Urs u1 = new Urs(22, "Balloo", 250, true, 'M');

            Console.WriteLine(p1);
            Console.WriteLine(u1);

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(u1);
            z1.ListaAnimale.Add(p1);

            z1.ListaAnimale.Sort();

            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            Animal a4 = new Animal(25, "Croco", 120);
            z2.ListaAnimale.Add(a4);

            Console.WriteLine(z2);
            Console.WriteLine(z1);
        }
    }
}
