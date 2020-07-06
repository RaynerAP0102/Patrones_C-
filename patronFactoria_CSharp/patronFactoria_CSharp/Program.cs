using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronFactoria_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu rol familiar: ");
            string rol = Console.ReadLine();

            Interface jerarquia = Creador.VerObjeto(rol);

            Console.WriteLine(jerarquia.GetNombre());
            Console.ReadLine();
        }
    }
}
