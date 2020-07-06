using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace patronComando_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisor LG = new Televisor();
            ControlRemoto mIControlRemoto = new ControlRemoto(LG);
            int opcion;

            do
            {
                Console.WriteLine("               <<<<<<<<<<<<<<<<MENU TELEVISOR>>>>>>>>>>>>>\n");
                Console.WriteLine("1-Encender \n2-Cambiar a modo antena \n3-Cambiar canal \n4-Cambiar a modo HDMI \n5-Subir volumen \n6-Configurar televisor \n7-Mutear televisor \n8-Bajar volumen \n9-Apagar \n10-Salir" );

                Console.WriteLine("Seleccione una accion a realizar: \n");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    mIControlRemoto.Boton(0);
                }
                if (opcion == 2)
                {
                    mIControlRemoto.Boton(1);
                }
                if (opcion == 3)
                {
                    mIControlRemoto.Boton(2);
                }
                if (opcion == 4)
                {
                    mIControlRemoto.Boton(3);
                }
                if (opcion == 5)
                {
                    mIControlRemoto.Boton(4);
                }
                if (opcion == 6)
                {
                    mIControlRemoto.Boton(5);
                }
                if (opcion == 7)
                {
                    mIControlRemoto.Boton(6);
                }
                if (opcion == 8)
                {
                    mIControlRemoto.Boton(7);
                }
                if (opcion == 9)
                {
                    mIControlRemoto.Boton(8);
                }

                Thread.Sleep(4000);
                Console.Clear();
            } while (opcion != 10);
        }
    }
}
