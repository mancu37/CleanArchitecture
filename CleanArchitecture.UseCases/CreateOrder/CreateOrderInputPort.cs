using CleanArchitecture.UseCases.Dto.CreateOrden;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.UseCases.CreateOrder
{
    public class CreateOrderInputPort : CreateOrderParams, IRequest<int>
    {

    }
}
