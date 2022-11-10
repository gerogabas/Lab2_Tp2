using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Labo2TP2
{
    [Serializable]
    internal abstract class Hospedaje:IComparable<Hospedaje>
    {
        //Todas con get publico para mostrar la info en el front.
        // protected double Precio { get; set; }
        public string Direccion { get; private set; }
        public int NroPropiedad { get; private set; }
        Bitmap[] imagenes = null;
        OpcionOrdenHospedaje opcion;

        public Hospedaje( string dire, int nroPropiedad) //double precio,
        {
            //Precio = precio;
            Direccion = dire;
            NroPropiedad = nroPropiedad;
        }

        //int pos es util para Hotel, pero no para Casa.
        public abstract double SetPrecio(int pos, double precioBase);
        public abstract Reserva Alquilar(int pos, int huespedes, Cliente cliente, DateTime fechaEmicion, int diasAlq,
            DateTime checkIn, DateTime checkOut);
        public void AgregarImagenes(Bitmap[] img)
        {
            imagenes = img;
        }

        #region Metodos Overrideados
        public override string ToString()
        {
            return base.ToString();
        }

        #region Comparador

        public void SeleccionarFiltro(OpcionOrdenHospedaje p)
        {
            opcion = p;
        }
        
        public int CompareTo(Hospedaje other)
        {
            if (other == null) return -1;
            switch (opcion)
            {
                case OpcionOrdenHospedaje.DIRECCION: return this.Direccion.CompareTo(other.Direccion);
                case OpcionOrdenHospedaje.NROPROPIEDAD: return this.NroPropiedad.CompareTo(other.NroPropiedad);
                default: return 0;
            }
        }

        
        #endregion
        #endregion

    }
}




