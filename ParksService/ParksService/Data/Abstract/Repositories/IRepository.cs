using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Data.Abstract.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Find(Func<T, bool> predicate);
        IEnumerable<T> GetAll();
        void WriteData(IEnumerable<T> data);
    }
}
