using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Entities.Specifications
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> Expression { get; }

        public bool IsSatisfied(T entity)
        {
            Func<T, bool> expressionDelegate = Expression.Compile();
            return expressionDelegate(entity);
        }
    }
}
