using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.UseCases.Dto.CreateOrden
{
    public class CreateOrdenParams
    {
        public int ClienteId { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public List<CreateDetalleOrdenParams> DetalleOrden { get; set; } = new List<CreateDetalleOrdenParams>();

    }
}
