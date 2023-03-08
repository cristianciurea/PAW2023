﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1048
{
    abstract class Persoana
    {
        private int cod;
        private char sex;

        protected int Cod { get => cod; set => cod = value; }
        protected char Sex { get => sex; set => sex = value; }

        public Persoana()
        {
            cod = 0;
            sex = 'F';
        }

        public Persoana(int c, char s)
        {
            cod = c;
            sex = s;
        }

        public override string ToString()
        {
            return "Persoana cu codul " + cod + " are sexul " +
                sex;
        }

        public abstract string spuneAnNastere();
    }
}
