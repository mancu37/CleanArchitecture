using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.UseCases.Dto.CreateOrden
{
    public class CreateOrderParams
    {
        public int CustomerId { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public List<CreateOrderDetailsParams> OrderDetail { get; set; } = new List<CreateOrderDetailsParams>();

    }
}
