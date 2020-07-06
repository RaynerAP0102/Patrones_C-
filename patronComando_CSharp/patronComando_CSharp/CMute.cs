using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronComando_CSharp
{
    class CMute : IComando
    {
        Televisor LG;
        public CMute(Televisor televisor)
        {
            LG = televisor;
        }
        public void Realizar()
        {
            LG.Mute();
        }
    }
}
