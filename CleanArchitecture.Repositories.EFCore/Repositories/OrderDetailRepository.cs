using CleanArchitecture.Entities;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Repositories.EFCore.Context;

namespace CleanArchitecture.Repositories.EFCore.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        readonly MyDbContext Context;

        public OrderDetailRepository(MyDbContext context) => Context = context;

        public void Create(OrderDetail entity)
        {
            Context.Add(entity);
        }
    }
}
