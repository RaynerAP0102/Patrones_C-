using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class CEncender : IComando
    {
        Televisor LG;
        public CEncender(Televisor televisor)
        {
            LG = televisor;
        }

        public void Realizar()
        {
            LG.Encender();
        }
    }
}
