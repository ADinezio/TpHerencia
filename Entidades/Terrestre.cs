using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Terrestre:Motorizado
    {
        #region constructores
        public Terrestre(string tipo, bool descapotable,string nombreModelo, int pasajeros, int ruedas, float precio, string color, int capacidadCombustible, int cantidadMotores, string tipoDeCaja) : base(nombreModelo, pasajeros, ruedas, precio, color, capacidadCombustible, cantidadMotores, tipoDeCaja)
        {
            Tipo = tipo;
            Descapotable = descapotable;
        }
        #endregion

        #region propiedades
        public string Tipo { get; set; }
        public bool Descapotable { get; set; }
        #endregion
    }
}
