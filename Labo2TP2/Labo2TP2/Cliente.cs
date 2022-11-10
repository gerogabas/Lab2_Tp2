using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Labo2TP2
{
    [Serializable]
    internal class Cliente:IComparable<Cliente>
    {
        //Todas con get publico para mostrar la info en el front.
        int opcionOrdenamiento = 0;
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Mail { get; private set; }
        public string Celular { get; private set; }
        public string CodigoArea { get; private set; }
        public string Dni { get; private set; }
         

        //Cliente se recuerda a si mismo y nada mas.
        public Cliente(string nombre, string apellido, string mail, string celular, string codigoArea, string dni)
        {
            try
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Mail = mail;
                this.Celular = celular;
                this.CodigoArea = codigoArea;
                this.Dni = dni;
            }
            catch(RangoIncorrectoExcepcion rango)
            {
                throw new RangoIncorrectoExcepcion(rango.Message);
            }            
        }
        #region Comparador

        public void Criterio(int orden)
        {
            opcionOrdenamiento = orden;
        }
        public int CompareTo(Cliente other)
        {
            if (other == null) return -1;
            switch (opcionOrdenamiento)
            {
                case 0: return this.Dni.CompareTo(other.Dni);
                case 1: return this.Nombre.CompareTo(other.Nombre);
                case 2: return this.Apellido.CompareTo(other.Apellido);
                case 3: return this.Mail.CompareTo(other.Mail);
                case 4: return this.Celular.CompareTo(other.Celular);
                case 5: return this.CodigoArea.CompareTo(other.CodigoArea);
                default: return this.Dni.CompareTo(other.Dni);
            }
        } 
        #endregion
    }
}
