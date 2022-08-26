using CleanArchitecture.Entities;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.Specifications;
using CleanArchitecture.Repositories.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Repositories.EFCore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        readonly MyDbContext Context;

        public OrderRepository(MyDbContext context) => Context = context;

        public void Create(Order orden)
        {
            Context.Add(orden);
        }

        public IEnumerable<Order> GetOrdenesBySpecification(Specification<Order> specification)
        {
            var expressionDelegate = specification.Expression.Compile();
            return Context.Orders.Where(expressionDelegate);
        }
    }
}
