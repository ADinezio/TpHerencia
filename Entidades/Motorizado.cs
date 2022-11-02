using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Motorizado:Vehiculo
    {
        #region constructores
        public Motorizado(string nombreModelo, int pasajeros, int ruedas,float precio, string color,int capacidadCombustible,int cantidadMotores,string tipoDeCaja) : base(nombreModelo,pasajeros,ruedas,precio,color)
        {
            if (capacidadCombustible <= 0) CapacidadCombustible = 0;
            else CapacidadCombustible = capacidadCombustible;
            if (cantidadMotores <= 0) CantidadMotores = 1;
            else CantidadMotores = cantidadMotores;
            TipoDeCaja = tipoDeCaja;
        }

        #endregion

        #region propiedades
        public int CapacidadCombustible { get; set; }
        public int CantidadMotores { get; set; }
        public string TipoDeCaja { get; set; }
        #endregion
    }
}
