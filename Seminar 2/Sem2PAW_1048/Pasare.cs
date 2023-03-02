using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1048
{
    class Pasare: Animal
    {
        private string specie;
        private string culoare;

        public Pasare():base()
        {
            specie = "zburatoare";
            culoare = "verde";
        }

        public Pasare(int v, string n, float g, string s, string c):
            base(v, n, g)
        {
            specie = s;
            culoare = c;
        }

        public string Specie { get => specie; set => specie = value; }
        public string Culoare { get => culoare; set => culoare = value; }

        public override string ToString()
        {
            return base.ToString() + " si specia " + specie +
                " si culoarea " + culoare;
        }
    }
}
