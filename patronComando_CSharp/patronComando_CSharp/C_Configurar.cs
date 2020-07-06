using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class C_Configurar : IComando
    {
        Televisor LG;
        public C_Configurar(Televisor televisor)
        {
            LG = televisor;
        }
        public void Realizar()
        {
            LG.Configurar();
        }
    }
}
