using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes{get;}
        List<string> IncludesStrings { get; }
        Expression<Func<T, object>> OrderBy { get; }
        
        int Take { get; }
        int Skip { get; }

    }
}
