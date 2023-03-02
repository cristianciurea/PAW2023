using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1048
{
    class Animal: ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private float greutate;

        public Animal()
        {
            varsta = 0;
            nume = "Anonim";
            greutate = 0.0f;
        }

        public Animal(int v, string n, float g)
        {
            varsta = v;
            nume = n;
            greutate = g;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public float Greutate
        {
            get { return greutate; }
            set { if (value > 0) greutate = value; }
        }

        public override string ToString()
        {
            return "Animalul " + nume + " are varsta " + varsta +
                " si greutatea " + greutate;
        }

        public int CompareTo(object obj)
        {
            Animal a = (Animal)obj;
            if (this.greutate < a.greutate)
                return -1;
            else
                if (this.greutate > a.greutate)
                return 1;
            else
                return string.Compare(this.nume, a.nume);
        }

        public static Animal operator+(Animal a, float g)
        {
            a.greutate += g;
            return a;
        }

        public static Animal operator+(float g, Animal a)
        {
            return a + g;
        }
    }
}
