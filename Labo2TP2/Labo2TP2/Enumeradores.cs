using System;
using System.IO;
using System.Runtime.Serialization;

namespace Labo2TP2
{
    [Serializable]
    enum OpcionOrdenHospedaje
    {
        DIRECCION,
        NROPROPIEDAD
    }
    enum OpcionOrdenCasa
    {
        DIRECCION,
        NROPROPIEDAD,
        DIASMINIMOS,
        CANTIDADCAMAS,
        LIBRE,
        MASCOTAS,
        DESAYUNO,
        WIFI,
        LIMPIEZA,
        PILETA,
        COCHERA,
    }
    enum OpcionOrdenHotel
    {
        DIRECCION,
        NROPROPIEDAD,
        ESTRELLAS,
        NOMBRE,
        PRECIOBASE,
    }
    enum OpcionOrdenReserva
    {
        DIRECCION,
        NROPROPIEDADES,
        HUESPEDES,
        DIASALQUILADOS,
        COSTODIA,
        COSTOTOTAL,
        DATOSCLIENTES,
        FECHAEMISION,
        CHECKIN,
        CHECKOUT,
    }
    enum OpcionOrdenReservaHotel
    {
        DIRECCION,
        NROPROPIEDADES,
        HUESPEDES,
        DIASALQUILADOS,
        COSTODIA,
        COSTOTOTAL,
        DATOSCLIENTES,
        FECHAEMISION,
        CHECKIN,
        CHECKOUT,
        NROHABITACION,
        TIPOHABITACION,
    }

    enum TipoHabitacion
    {
        SIMPLE,
        DOBLE,
        TRIPLE,
    }

}
