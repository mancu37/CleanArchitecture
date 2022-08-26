using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Repositories.EFCore.Context
{
    class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;database=CleanArchitecture");
            return new MyDbContext(optionBuilder.Options);
        }
    }
}
