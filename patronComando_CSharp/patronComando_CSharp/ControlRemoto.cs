using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class ControlRemoto
    {
        private IComando[] todosLosComandos = new IComando[9];

        public ControlRemoto(Televisor televisor)
        {
            todosLosComandos[0] = new CEncender(televisor);
            todosLosComandos[1] = new C_Cambiar_A_Antena (televisor);
            todosLosComandos[2] = new C_Cambiar_Canal(televisor);
            todosLosComandos[3] = new C_Cambiar_A_HDMI(televisor);
            todosLosComandos[4] = new CSubirVolumen(televisor);
            todosLosComandos[5] = new C_Configurar(televisor);
            todosLosComandos[6] = new CMute(televisor);
            todosLosComandos[7] = new CBajarVolumen(televisor);
            todosLosComandos[8] = new CApagar(televisor);
        }
        public void Boton(int Boton)
        {
            todosLosComandos[Boton].Realizar();
        }
    }
}
