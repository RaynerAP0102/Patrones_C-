using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class C_Cambiar_Canal : IComando
    {
        Televisor LG;
        public C_Cambiar_Canal(Televisor televisor)
        {
            LG = televisor;
        }
        public void Realizar()
        {
            LG.Cambiar_Canal();
        }
    }
}
