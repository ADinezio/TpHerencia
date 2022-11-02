using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        #region constructores
        public Vehiculo(string nombreModelo, int pasajeros, int ruedas, float precio, string color)
        {
            NombreModelo = nombreModelo;
            if (pasajeros <= 0) pasajeros = 0;
            else Pasajeros = pasajeros;
            if(ruedas <= 0) Ruedas = 0; 
            else Ruedas = ruedas;
            if(precio <=0) Precio= 0;
            else Precio= precio;    
            Color = color;

        }
        #endregion

        #region propiedades
        public string NombreModelo { get; set; }
        public int Pasajeros { get; set; }
        public int Ruedas { get; set; }
        public float Precio { get; set; }
        public string Color { get; set; }
        #endregion
    }
}
