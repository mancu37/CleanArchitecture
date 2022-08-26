using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Entities
{
    public class DetalleOrden
    {
        public int OrdenId { get; set; }
        public int ProductoId { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public Orden Orden { get; set; } = new Orden();
    }
}
