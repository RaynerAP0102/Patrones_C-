using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class C_Cambiar_A_Antena : IComando
    {
        Televisor LG;
        public C_Cambiar_A_Antena(Televisor televisor)
        {
            LG = televisor;
        }
        public void Realizar()
        {
            LG.Cambiar_A_Antena();
        }
    }
}
