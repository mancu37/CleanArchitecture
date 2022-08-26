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
    public class OrdenRepository : IOrdenRepository
    {
        readonly MyDbContext Context;

        public OrdenRepository(MyDbContext context) => Context = context;

        public void Create(Orden orden)
        {
            Context.Add(orden);
        }

        public IEnumerable<Orden> GetOrdenesBySpecification(Specification<Orden> specification)
        {
            var expressionDelegate = specification.Expression.Compile();
            return Context.Ordenes.Where(expressionDelegate);
        }
    }
}
