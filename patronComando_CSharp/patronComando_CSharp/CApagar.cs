using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class CApagar : IComando
    {
        Televisor LG;
        public CApagar(Televisor televisor)
        {
            LG = televisor;
        }

        public void Realizar ()
        {
            LG.Apagar();
        }
    }
}
