using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Repositories.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Repositories.EFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly MyDbContext Context;

        public UnitOfWork(MyDbContext context) => Context = context;

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}
