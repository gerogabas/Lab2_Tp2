using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP2
{
    [Serializable]
    internal class Habitacion
    {
        //Todas con get publico para mostrar la info en el front.
        public int NroHabitacion { get; private set; }
        public TipoHabitacion Tipo { get; private set; }
        public bool Libre { get; private set; }
        public Habitacion(int nro, TipoHabitacion tipo)
        {
            this.NroHabitacion = nro;
            this.Tipo = tipo;
            Libre = true;
        }
        //Habitacion se recuerda a si misma y nada mas.

        //Cambia el valor de Libre.
        public void ReservarLiberar()
        {
            Libre = !Libre;
        }
    }
}
