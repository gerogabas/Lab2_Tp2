using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP2
{
    internal class RangoIncorrectoExcepcion:ApplicationException
    {
        public RangoIncorrectoExcepcion():base($@"DNI fuera de rango: estar entre 5 y 90 millones")
        {

        }
        public RangoIncorrectoExcepcion(string msg) : base(msg)
        {

        }
        public RangoIncorrectoExcepcion(string msg, Exception innerException) : base(msg, innerException)
        {

        }
    }
}
