using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aereo:Motorizado
    {
        #region contructores
        public Aereo(string propulsion,string eje,string nombreModelo, int pasajeros, int ruedas, float precio, string color, int capacidadCombustible, int cantidadMotores, string tipoDeCaja) : base(nombreModelo, pasajeros, ruedas, precio, color, capacidadCombustible, cantidadMotores, tipoDeCaja)
        {
            Propulsion = propulsion;
            Eje = eje;  
        }
        #endregion

        #region propiedades
        public string Propulsion { get; set; }
        public string Eje { get; set; }
        #endregion
    }
}
