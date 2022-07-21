using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Src
{
    internal class Monstro
    {
        string Name { get; set; }
        string Color { get; set; }
        int NmbrArms { get; set; }
        int NmbrEyes { get; set; }

        public Monstro(string name, string color, int nmbrArms, int nmbrEyes)
        {
            Name = name;
            Color = color;
            NmbrArms = nmbrArms;
            NmbrEyes = nmbrEyes;
        }

        public string Grunt()
        {
            return "Grrrrrww!!";
        }

        public override string ToString()
        {
            return $"Eu sou o {Name}, tenho a cor {Color}, tenho {NmbrArms} braços e {NmbrEyes} olhos.";
        }
    }
}
