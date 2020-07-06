using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronFactoria_CSharp
{
    public class Padre : Interface
    {
        public string GetNombre()
        {
            return "El nombre del padre";
        }
        public string GetApellido()
        {
            return "El apellido del padre";
        }
    }
}
