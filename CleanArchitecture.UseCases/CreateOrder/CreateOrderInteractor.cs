using CleanArchitecture.Entities;
using CleanArchitecture.Entities.Exceptions;
using CleanArchitecture.Entities.Interfaces;
using MediatR;

namespace CleanArchitecture.UseCases.CreateOrder
{
    public class CreateOrderInteractor : IRequestHandler<CreateOrderInputPort, int>
    {
        readonly IOrderRepository OrderRepository;
        readonly IOrderDetailRepository OrderDetailRepository;
        readonly IUnitOfWork UnitOfWork;

        public CreateOrderInteractor(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, IUnitOfWork unitOfWork)
         => (OrderRepository, OrderDetailRepository, UnitOfWork) = (orderRepository, orderDetailRepository, unitOfWork);

        public async Task<int> Handle(CreateOrderInputPort request, CancellationToken cancellationToken)
        {
            Order order = new Order()
            {
                CustomerId = request.CustomerId,
                Date = DateTime.Now,
                Address = request.Address,
                City = request.City,
                Country = request.Country,
                PostalCode = request.PostalCode
            };

            OrderRepository.Create(order);

            foreach (var item in request.OrderDetail)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Order = order,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId
                };

                OrderDetailRepository.Create(orderDetail);
            }

            try
            {
                await UnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al crear la orden.", ex.Message);
            }
            
            return order.Id;
        }
    }
}
