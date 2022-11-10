using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Labo2TP2
{
    [Serializable]
    internal class Reserva:IComparable<Reserva>
    {
        

        //Todas con get publico para mostrar la info en el front.
        public string Direccion { get; set; }
        public int NroPropiedad { get; set; }
        public int Huespedes { get; set; }
        public int DiasAlquilados { get; set; }
        public double CostoDia { get; set; }
        public double CostoTotal { get; set; }
        public Cliente DatosCliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        OpcionOrdenReserva opcion;
        public Reserva(string dire, int nroPropiedad,int huespedes,int diasAlq,
            double costoDia,double costoTotal,Cliente datosCliente,
            DateTime fechaEmision,DateTime checkIn,DateTime checkOut)
        {
            Direccion = dire;
            NroPropiedad = nroPropiedad;
            Huespedes = huespedes;
            DiasAlquilados = diasAlq;
            CostoDia = costoDia;
            CostoTotal = costoTotal;
            DatosCliente = datosCliente;
            FechaEmision = fechaEmision;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public virtual void ExtenderEstadia(int dias)
        {
            DiasAlquilados += dias;
            CheckOut = CheckOut.AddDays(dias);
        }

        #region Comparador

        public void SeleccionarFiltro(OpcionOrdenReserva p)
        {
            opcion = p;
        }
        public int CompareTo(Reserva other)
        {
            if (other == null) return -1;
            switch (opcion)
            {
                case OpcionOrdenReserva.CHECKIN: return this.CheckIn.CompareTo(other.CheckIn);
                case OpcionOrdenReserva.CHECKOUT: return this.CheckOut.CompareTo(other.CheckOut);
                case OpcionOrdenReserva.COSTODIA: return this.CostoDia.CompareTo(other.CostoDia);
                case OpcionOrdenReserva.COSTOTOTAL: return this.CostoTotal.CompareTo(other.CostoTotal);
                case OpcionOrdenReserva.DATOSCLIENTES: return this.DatosCliente.CompareTo(other.DatosCliente);
                case OpcionOrdenReserva.DIASALQUILADOS: return this.DiasAlquilados.CompareTo(other.DiasAlquilados);
                case OpcionOrdenReserva.DIRECCION: return this.Direccion.CompareTo(other.Direccion);
                case OpcionOrdenReserva.FECHAEMISION: return this.FechaEmision.CompareTo(other.FechaEmision);
                case OpcionOrdenReserva.HUESPEDES: return this.Huespedes.CompareTo(other.Huespedes);
                case OpcionOrdenReserva.NROPROPIEDADES: return this.NroPropiedad.CompareTo(other.NroPropiedad);
                default: return 0;
            }
        }
        #endregion

    }
}
