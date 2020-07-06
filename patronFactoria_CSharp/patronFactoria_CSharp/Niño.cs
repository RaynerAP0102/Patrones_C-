using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronFactoria_CSharp
{
    class Niño : Interface
    {
        public string GetNombre()
        {
            return "El nombre del niño";
        }
        public string GetApellido()
        {
            return "El apellido del niño";
        }
    }
}
