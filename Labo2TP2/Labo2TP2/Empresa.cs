using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP2
{
    [Serializable]
    internal class Empresa:IComparer<Casa>,IComparer<Reserva>,IComparer<Cliente>,IComparer<Hotel>
    {
        //Todas con get publico para mostrar la info en el front.
        public List<Hospedaje> ListaHospedajes { get; private set; }
        public List<Cliente> ListaClientes { get; private set; }
        public List<Reserva> ListaReservas { get; private set; }
        public List<Reserva> Historial { get; private set; }

        public Empresa()
        {
            ListaHospedajes = new List<Hospedaje>();
            ListaClientes = new List<Cliente>();
            ListaReservas = new List<Reserva>();
            Historial = new List<Reserva>();
        }

        //Recibe el hospedaje y hace una reserva dependiendo del tipo de este.
        public void Reservar(Hospedaje miHospedaje, int pos, int huespedes, int posCliente, DateTime fechaEmicion,
            int diasAlq, DateTime checkIn, DateTime checkOut)
        {
            if(miHospedaje is Hotel)
            {
                ListaReservas.Add((ReservaHotel)miHospedaje.Alquilar(pos, huespedes, ListaClientes[posCliente], fechaEmicion, diasAlq, checkIn, checkOut));
            }
            if(miHospedaje is Casa)
            {
                ListaReservas.Add(miHospedaje.Alquilar(pos, huespedes, ListaClientes[posCliente], fechaEmicion, diasAlq, checkIn, checkOut));
            }
        }

        //Recibe un cliente nuevo y pisa el de esa posicion.
        public void ModificarCliente(int pos, Cliente miCliente)
        {
            ListaClientes[pos] = miCliente;
        }
        public void AgregarHospedaje(Hospedaje miHospedaje)
        {
            ListaHospedajes.Add(miHospedaje);
        }

        //Recibe un hospedaje nuevo y pisa el de esa posicion.
        public void ModificarHospedaje(int pos, Hospedaje miHospedaje)
        {
            ListaHospedajes[pos] = miHospedaje;
        }

        //dar de baja TESTEADO Y ANDANDO
        public void DarDeBaja(Object objeto)
        {
            if (objeto is Hotel)
                ListaHospedajes.Remove((Hospedaje)objeto);
            if (objeto is Casa)
                ListaHospedajes.Remove((Hospedaje)objeto);
            if (objeto is Reserva)
            {
                Historial.Add((Reserva)objeto);
                ListaReservas.Remove((Reserva)objeto);
            }
            if(objeto is Cliente)
                ListaClientes.Remove((Cliente)objeto);
        }

        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        

        //Termina una reserva y la añade al historial.
        public void CheckOutAHistorial(Reserva reserva)
        {
            ListaReservas.Remove(reserva);
            Historial.Add(reserva);
        }

        #region Comparadores
        public int Compare(Cliente x, Cliente y)
        {
            if (x==null && y == null) return -1;
            return x.CompareTo(y);

        }

        public int Compare(Reserva x, Reserva y)
        {
            if (x==null && y==null) return -1;
            return x.CompareTo(y);
        }

        public int Compare(Casa x, Casa y)
        {
            throw new NotImplementedException();
        }

        public int Compare(Hotel x, Hotel y)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
