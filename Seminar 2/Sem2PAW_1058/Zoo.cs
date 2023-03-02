using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1058
{
    class Zoo: ICloneable
    {
        private string denumire;
        private List<Animal> listaAnimale;
        /*private ArrayList listaAnimale2;
        private Animal[] vectorAnimale;*/

        public Zoo()
        {
            denumire = "Baneasa";
            listaAnimale = new List<Animal>();
        }

        public Zoo(string den, List<Animal> lista)
        {
            denumire = den;
            listaAnimale = lista; //shallow copy
        }

        public string Denumire { get => denumire; set => denumire = value; }
        internal List<Animal> ListaAnimale { get => listaAnimale; set => listaAnimale = value; }

        public object Clone()
        {
            Zoo clona =(Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach (Animal a in listaAnimale)
                listaNoua.Add((Animal)a.Clone());
                //listaNoua.Add(a);
            clona.listaAnimale = listaNoua;
            return clona;
        }

        public override string ToString()
        {
            string rezultat = "Zoo " + denumire + " are urmatoarele animale " +
                Environment.NewLine;
            foreach (Animal a in listaAnimale)
                rezultat += a.ToString()+Environment.NewLine;
            return rezultat;
        }
    }
}
