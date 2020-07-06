using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronFactoria_CSharp
{
    class Creador
    {
        public static Interface VerObjeto(string rol)
        {
            Interface jerarquia = null;
            if (rol.ToLower() == "niño")
            {
                jerarquia = new Niño();
            } 
            else
            {
                jerarquia = new Padre();
            }
            return jerarquia;
        }
    }
}
