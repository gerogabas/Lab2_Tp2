using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP2
{
    [Serializable]
    internal class Hotel : Hospedaje,IComparable<Hotel>

    {
        #region Atributos y propiedades

        //Todas con get publico para mostrar la info en el front.
        public Habitacion[] Habitaciones { get; private set; }
        public int[] cantHabitaciones { get; private set; }
        public int Estrellas { get; private set; }
        public string Nombre { get; private set; }
        public double PrecioBase { get; private set; }
        OpcionOrdenHotel opcion;
        #endregion

        #region Constructor
        public Hotel(int estrellas, string nombre, int[] habitacion, int nro, string direccion, double precioBase) :
            base(direccion, nro)
        {
            this.Estrellas = estrellas;
            this.Nombre = nombre;
            this.PrecioBase = precioBase;
            Habitacion[] habitaciones = new Habitacion[habitacion[0] + habitacion[1] + habitacion[2]];
            int nroHab = 1;
            
            for (int i = 0; i < habitacion[0]; i++)
                habitaciones[i] = new Habitacion(nroHab++, TipoHabitacion.SIMPLE);
            for (int i = habitacion[0]; i < habitacion[1]; i++)
                habitaciones[i] = new Habitacion(nroHab++, TipoHabitacion.DOBLE);
            for (int i = habitacion[0] + habitacion[1]; i < habitacion[2]; i++)
                habitaciones[i] = new Habitacion(nroHab++, TipoHabitacion.TRIPLE);
        }
        #endregion

        #region Metodos
        //Da el precioXDia.
        public override double SetPrecio(int posicion, double precioBase)
        {
            double precio = precioBase;

            if (Habitaciones[posicion].Tipo == TipoHabitacion.DOBLE)
            {
                precio += precio * 0.8;
            }

            if (Habitaciones[posicion].Tipo == TipoHabitacion.TRIPLE)
            {
                precio += precio * 1.5;
            }

            if (Estrellas == 3)
            {
                precio += precio * 0.4;
            }

            return precio;
        } 

        //Devuelve Reserva.
        public override Reserva Alquilar(int pos, int huespedes, Cliente cliente, DateTime fechaEmicion, int diasAlq, 
            DateTime checkIn, DateTime checkOut)
        {
            ReservaHotel miReserva = new ReservaHotel(Direccion, NroPropiedad, huespedes, diasAlq, 
                SetPrecio(pos, PrecioBase), (SetPrecio(pos, PrecioBase) * diasAlq), cliente, fechaEmicion, 
                checkIn, checkOut, pos, Habitaciones[pos].Tipo);

            Habitaciones[pos].ReservarLiberar();

            return miReserva;
        }
        override public string ToString()
        {
            switch (Estrellas)
            {
                case 2: return Nombre + " ★★";
                case 3: return Nombre + " ★★★";
                default: return Nombre;
            }
        }

        #region Comparador
        public void SeleccionarFiltro(OpcionOrdenHotel p)
        {
            opcion = p;
        }
        public int CompareTo(Hotel other)
        {
            if (other == null) return -1;
            switch (opcion)
            {
                case OpcionOrdenHotel.DIRECCION: return this.Direccion.CompareTo(other.Direccion);
                case OpcionOrdenHotel.NROPROPIEDAD: return this.Direccion.CompareTo(other.Direccion);
                case OpcionOrdenHotel.NOMBRE: return this.Nombre.CompareTo(other.Nombre);
                case OpcionOrdenHotel.ESTRELLAS: return this.Estrellas.CompareTo(other.Estrellas);
                case OpcionOrdenHotel.PRECIOBASE: return this.PrecioBase.CompareTo(other.PrecioBase);
                default: return 0;
            }
        }
        #endregion
        #endregion


    }
}
