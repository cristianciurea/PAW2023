using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1058
{
    class Sarpe: Animal
    {
        private bool esteVeninos;
        private int lungime;

        public Sarpe():base()
        {
            esteVeninos = true;
            lungime = 0;
        }

        public Sarpe(int v, string n, float g, bool este, int lg):
            base(v, n, g)
        {
            esteVeninos = este;
            lungime = lg;
        }

        public bool EsteVeninos { get => esteVeninos; set => esteVeninos = value; }
        public int Lungime { get => lungime; set => lungime = value; }

        public override string ToString()
        {
            return base.ToString() + " si lungimea " +lungime+
                " si este veninos "+esteVeninos;
        }
    }
}
