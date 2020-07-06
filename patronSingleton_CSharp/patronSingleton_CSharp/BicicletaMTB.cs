using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace patronSingleton_CSharp
{
    class BicicletaMTB
    {
        private static BicicletaMTB miBicicleta;

        private string marca;
        private int año;
        private string modelo;
        private string suspension;
        private string manillar;
        private string transmision;
        private string pedales;
        private string material;
        private string tamañoRuedas;
        private string sikeCuadro;

        private BicicletaMTB()
        {
            marca = "";
            año = 0000;
            modelo = "";
            suspension = "";
            manillar = "";
            transmision = "";
            pedales = "";
            material = "";
            tamañoRuedas = "";
            sikeCuadro = "";
        }

        public static BicicletaMTB VerBicicleta()
        {
            if (miBicicleta == null)
            {
                miBicicleta = new BicicletaMTB();
                Console.WriteLine("Bicicleta MTB Creada EXICTOSAMENTE!!!\n");
            }

            return miBicicleta;
        }

        public override string ToString()
        {
            return string.Format($"La bicicleta que compraste posee los siguientes detalles: \nMarca: {marca}  \nModelo: {modelo} " +
                $"\nAño: {año} \nSuspension: {suspension} \nManillar: {manillar} \nTransmision: {transmision} \nPedales: {pedales} " +
                $"\nMaterial: {material} \nTamaño ruedas: {tamañoRuedas} \nSike cuadro:{sikeCuadro}");
        }

        public void Asignacion(string marca, int año, string modelo, string suspension, string manillar, string transmision, string pedales, string material, string tamañoRuedas, string sikeCuadro)
        {
            this.marca = marca;
            this.año = año;
            this.modelo = modelo;
            this.suspension = suspension;
            this.manillar = manillar;
            this.transmision = transmision;
            this.pedales = pedales;
            this.material = material;
            this.tamañoRuedas = tamañoRuedas;
            this.sikeCuadro = sikeCuadro;
        }
    }
}       
