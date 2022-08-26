using CleanArchitecture.Entities.Specifications;

namespace CleanArchitecture.Entities.Interfaces
{
    public interface IOrderRepository
    {
        void Create(Order order);
        IEnumerable<Order> GetOrdenesBySpecification(Specification<Order> specification);
    }
}
