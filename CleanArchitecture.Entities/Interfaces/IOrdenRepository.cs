using CleanArchitecture.Entities.Specifications;

namespace CleanArchitecture.Entities.Interfaces
{
    public interface IOrdenRepository
    {
        void Create(Orden orden);
        IEnumerable<Orden> GetOrdenesBySpecification(Specification<Orden> specification);
    }
}
