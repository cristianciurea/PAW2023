using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1058
{
    class Girafa: Animal
    {
        private int inaltime;
        private char sex;

        public Girafa():base()
        {
            inaltime = 0;
            sex = 'F';
        }

        public Girafa(int v, string n, float g, int h, char s):
            base(v, n, g)
        {
            inaltime = h;
            sex = s;
        }

        public int Inaltime { 
            get => inaltime; 
            set => inaltime = value; 
        }
        public char Sex { get => sex; set => sex = value; }

        public override string ToString()
        {
            return base.ToString() + " si inaltime "+inaltime
                +" si sexul "+sex;
        }
    }
}
