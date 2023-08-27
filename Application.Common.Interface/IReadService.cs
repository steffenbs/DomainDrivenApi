using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    /// <summary>
    /// Used to get dtos based on query Q
    /// </summary>
    /// <typeparam name="T">Returns dto of type T</typeparam>
    public interface IReadService<T, Q>
    {
        Task<T> ReadAsync(Q query);
    }
   
    /// <summary>
    /// Return dto of type T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadService<T>
    {
        Task<T> ReadAsync();
    }
}
