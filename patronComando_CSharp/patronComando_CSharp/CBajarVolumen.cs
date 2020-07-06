using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class CBajarVolumen : IComando
    {
        Televisor LG;
        public CBajarVolumen(Televisor televisor)
        {
            LG = televisor;
        }
        public void Realizar()
        {
            LG.BajarVolumen();
        }
    }
}
