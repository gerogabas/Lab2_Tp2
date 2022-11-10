using System;

namespace Labo2TP2
{
    [Serializable]
    internal class Casa : Hospedaje, IComparable<Casa>
    {
        #region Propiedades
        //Todas con get publico para mostrar la info en el front.
        public int DiasMinimos { get; private set; }
        public int CantidadCamas { get; private set; }
        public bool Cochera { get; private set; }
        public bool Pileta { get; private set; }
        public bool Limpieza { get; private set; }
        public bool Wifi { get; private set; }
        public bool Desayuno { get; private set; }
        public bool Mascotas { get; private set; }
        public bool Libre { get; private set; }
        public double PrecioXDia { get; private set; }
        OpcionOrdenCasa opcion; 
        #endregion


        //Constructor.
        public Casa(int diasMin, int camas, bool cochera, bool pileta, bool limpieza,
                        bool wifi, bool desayuno, bool mascotas, double precioBase,
                        string dire, int nroPropiedad) : base(dire, nroPropiedad)
        {
            DiasMinimos = diasMin;
            CantidadCamas = camas;
            Cochera = cochera;
            Pileta = pileta;
            Limpieza = limpieza;
            Wifi = wifi;
            Desayuno = desayuno;
            Mascotas = mascotas;
            this.PrecioXDia = SetPrecio(0, precioBase);
        }

        //Ignora/no usa el pos.
        public override Reserva Alquilar(int pos, int huespedes, Cliente cliente, DateTime fechaEmicion, int diasAlq,
            DateTime checkIn, DateTime checkOut)
        {
            Reserva miReserva = new Reserva(Direccion, NroPropiedad, huespedes, diasAlq, PrecioXDia, (PrecioXDia * diasAlq)
                , cliente, fechaEmicion, checkIn, checkOut);
            return miReserva;
        }

        //No teniamos valores en la consigna asi que invente.
        public override double SetPrecio(int pos, double precioBase)
        {
            double precio = precioBase;
            if (Cochera)
                precio += 200;
            if (Pileta)
                precio += 150;
            if (Wifi)
                precio += 50;
            if (Limpieza)
                precio += 100;
            if (Desayuno)
                precio += 200;
            if (Mascotas)
                precio += 40;
            precio += CantidadCamas * 100;

            return precio;
        }
        public void ReservarLiberar()
        {
            Libre = !Libre;
        }
        #region Comparador
        public void SeleccionarFiltro(OpcionOrdenCasa p)
        {
            opcion = p;
        }
        public int CompareTo(Casa other)
        {
            if (other == null) return -1;
            switch (opcion)
            {
                case OpcionOrdenCasa.DIASMINIMOS: return this.DiasMinimos.CompareTo(other.DiasMinimos);
                case OpcionOrdenCasa.CANTIDADCAMAS: return this.CantidadCamas.CompareTo(other.CantidadCamas);
                case OpcionOrdenCasa.COCHERA: return this.Cochera.CompareTo(other.Cochera);
                case OpcionOrdenCasa.PILETA: return this.Pileta.CompareTo(other.Pileta);
                case OpcionOrdenCasa.LIMPIEZA: return this.Limpieza.CompareTo(other.Limpieza);
                case OpcionOrdenCasa.WIFI: return this.Wifi.CompareTo(other.Wifi);
                case OpcionOrdenCasa.DESAYUNO: return this.Desayuno.CompareTo(other.Desayuno);
                case OpcionOrdenCasa.MASCOTAS: return this.Mascotas.CompareTo(other.Mascotas);
                default: return 0;
            }
        } 
        #endregion
    }
}
