using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class Televisor
    {
        public void Encender()
        {
            Console.WriteLine("Encendiendo televisor");
        }
        public void Apagar()
        {
            Console.WriteLine("Apagando televisor");
        }
        public void Cambiar_Canal()
        {
            Console.WriteLine("Cambiando el canal del televisor");
        }
        public void SubirVolumen()
        {
            Console.WriteLine("Subiendo volumen del televisor");
        }
        public void BajarVolumen()
        {
            Console.WriteLine("Bajando volumen del televisor");
        }
        public void Mute()
        {
            Console.WriteLine("Muteando el sonido del televisor");
        }
        public void Configurar()
        {
            Console.WriteLine("Configurando los canales del televisor");
        }
        public void Cambiar_A_HDMI()
        {
            Console.WriteLine("Televisor cambiado a modo HDMI");
        }
        public void Cambiar_A_Antena()
        {
            Console.WriteLine("Televisor cambiado a modo Antena");
        }

    }
}
