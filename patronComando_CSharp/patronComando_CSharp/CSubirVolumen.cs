using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class CSubirVolumen : IComando
    {
        Televisor LG;
        public CSubirVolumen(Televisor televisor)
        {
            LG = televisor;
        }
        public void Realizar()
        {
            LG.SubirVolumen();
        }
    }
}
