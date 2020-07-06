using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace patronSingleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BicicletaMTB nuevaBicicletaMTB = BicicletaMTB.VerBicicleta();

            nuevaBicicletaMTB.Asignacion("Scott", 2020, "Spark RC WT", "Rockshox Recon Gold RL 29", "Gub XL", "Sram Eagle XX1", 
                "Crank Brothers", "Fibra de carbono", "29 inch", "L");

            Console.WriteLine(nuevaBicicletaMTB);
            Console.ReadLine();

        }
    }
}
