using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1048
{
    class Zoo: ICloneable
    {
        private string denumire;
        private List<Animal> listaAnimale;
        /*private ArrayList listaAnimale;
        private Animal[] vectorAnimale;*/

        public Zoo()
        {
            denumire = "Baneasa";
            listaAnimale = new List<Animal>();
        }

        public string Denumire { get => denumire; set => denumire = value; }
        internal List<Animal> ListaAnimale { get => listaAnimale; set => listaAnimale = value; }

        public object Clone()
        {
            Zoo clona = (Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach (Animal a in listaAnimale)
                //listaNoua.Add(a);
                listaNoua.Add((Animal)a.Clone());
            clona.listaAnimale = listaNoua;
            return clona;
        }

        public override string ToString()
        {
            string rezultat = "Zoo " + denumire + " are urmatoarele animale " +
                Environment.NewLine;
            foreach (Animal a in listaAnimale)
                rezultat += a.ToString() + Environment.NewLine;
            return rezultat;
        }
    }
}
