using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Entities.Exceptions
{
    public class GeneralException : Exception
    {
        public string? Detalle { get; set; }

        public GeneralException()
        {

        }

        public GeneralException(string mensaje) : base(mensaje)
        {            
        }

        public GeneralException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

        public GeneralException(string titulo, string detalle) : base(titulo)
        {
            Detalle = detalle;
        }
    }
}
