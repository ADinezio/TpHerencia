using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class NoMotorizado:Vehiculo
    {
        #region constructores
        public NoMotorizado(string tipoDeFrenos, int cantidadRuedas,bool cambios ,string nombreModelo, int pasajeros, int ruedas, float precio, string color) : base(nombreModelo, pasajeros, ruedas, precio, color)
        {
            TipoDeFrenos = tipoDeFrenos;
            if(cantidadRuedas<=0) CantidadRuedas=2;
            else CantidadRuedas=cantidadRuedas;
            Cambios = cambios;
        }
        #endregion

        #region propiedades
        public string TipoDeFrenos { get; set; }
        public int CantidadRuedas { get; set; }
        public bool Cambios { get; set; }
        #endregion

    }
}
