using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP2
{
    [Serializable]
    internal class ReservaHotel:Reserva
    {

        public int NroHabitacion { get; private set; }
        public TipoHabitacion TipoHabitacion { get; private set; }
        OpcionOrdenReservaHotel opcion;

        public ReservaHotel(string dire, int nroPropiedad, int huespedes, int diasAlq, double costoDia, 
            double costoTotal, Cliente datosCliente, DateTime fechaEmision, DateTime checkIn, DateTime checkOut, 
            int nroHab, TipoHabitacion tipo) : base(dire, nroPropiedad, huespedes, diasAlq, costoDia, costoTotal, 
                datosCliente, fechaEmision, checkIn, checkOut)
        {
            this.NroHabitacion = nroHab;
            this.TipoHabitacion = tipo;

        }
        #region Comparador

        public void SeleccionarFiltro(OpcionOrdenReservaHotel p)
        {
            opcion = p;
        }
        public int CompareTo(ReservaHotel other)
        {
            if (other == null) return -1;
            switch (opcion)
            {
                case OpcionOrdenReservaHotel.CHECKIN: return this.CheckIn.CompareTo(other.CheckIn);
                case OpcionOrdenReservaHotel.CHECKOUT: return this.CheckOut.CompareTo(other.CheckOut);
                case OpcionOrdenReservaHotel.COSTODIA: return this.CostoDia.CompareTo(other.CostoDia);
                case OpcionOrdenReservaHotel.COSTOTOTAL: return this.CostoTotal.CompareTo(other.CostoTotal);
                case OpcionOrdenReservaHotel.DATOSCLIENTES: return this.DatosCliente.CompareTo(other.DatosCliente);
                case OpcionOrdenReservaHotel.DIASALQUILADOS: return this.DiasAlquilados.CompareTo(other.DiasAlquilados);
                case OpcionOrdenReservaHotel.DIRECCION: return this.Direccion.CompareTo(other.Direccion);
                case OpcionOrdenReservaHotel.FECHAEMISION: return this.FechaEmision.CompareTo(other.FechaEmision);
                case OpcionOrdenReservaHotel.HUESPEDES: return this.Huespedes.CompareTo(other.Huespedes);
                case OpcionOrdenReservaHotel.NROPROPIEDADES: return this.NroPropiedad.CompareTo(other.NroPropiedad);
                case OpcionOrdenReservaHotel.NROHABITACION: return this.NroHabitacion.CompareTo(other.NroHabitacion);
                case OpcionOrdenReservaHotel.TIPOHABITACION: return this.TipoHabitacion.CompareTo(other.TipoHabitacion);
                default: return 0;
            }
        }
        #endregion





        //public void calse()
        //{
        //    ReservaHotel coso = new ReservaHotel("a", 3, 4, 5, 7, 8, new Cliente("dsa", "asd", "grew", "whw", "hwwh", "whh"),
        //        DateTime.Now, DateTime.Now, DateTime.Now + new TimeSpan(123456723), 5, TipoHabitacion.TRIPLE);
        //    coso.SeleccionarFiltro(OpcionOrdenReservaHotel.NROHABITACION);
        //}       
    }
}
