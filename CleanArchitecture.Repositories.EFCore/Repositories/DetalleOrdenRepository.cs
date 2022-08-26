using CleanArchitecture.Entities;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Repositories.EFCore.Context;

namespace CleanArchitecture.Repositories.EFCore.Repositories
{
    public class DetalleOrdenRepository : IDetalleOrdenRepository
    {
        readonly MyDbContext Context;

        public DetalleOrdenRepository(MyDbContext context) => Context = context;

        public void Create(DetalleOrden entity)
        {
            Context.Add(entity);
        }
    }
}
