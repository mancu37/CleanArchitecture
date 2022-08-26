using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.UseCases.Dto.CreateOrden
{
    public class CreateOrderParams
    {
        public int ClienteId { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public List<CreateOrderDetailsParams> DetalleOrden { get; set; } = new List<CreateOrderDetailsParams>();

    }
}
