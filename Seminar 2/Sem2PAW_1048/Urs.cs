using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1048
{
    class Urs: Animal
    {
        private bool hiberneaza;
        private char sex;

        public Urs():base()
        {
            hiberneaza = true;
            sex = 'M';
        }

        public Urs(int v, string n, float g, bool h, char s):
            base(v, n, g)
        {
            hiberneaza = h;
            sex = s;
        }

        public bool Hiberneaza { get => hiberneaza; 
            set => hiberneaza = value; }
        public char Sex { get => sex; set => sex = value; }

        public override string ToString()
        {
            return base.ToString() + " si hiberneaza "+hiberneaza+
                " si are sexul "+sex;
        }
    }
}
