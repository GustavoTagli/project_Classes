using System;
using Classes.Src;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monstro Barney = new Monstro("Barney", "Burgundy", 2, 2);
            Monstro Sullivan = new Monstro("Sullivan", "Blue", 2, 2);
            Monstro Wazowski = new Monstro("Wazowski", "Green", 2, 1);
            Monstro FourArms = new Monstro("Four Arms", "Red", 4, 4);

            Console.WriteLine(Barney.ToString());
            Console.WriteLine(Sullivan.ToString());
            Console.WriteLine(Wazowski.ToString());
            Console.WriteLine(FourArms.ToString());
            Console.WriteLine(FourArms.Grunt());
        }
    }
}
