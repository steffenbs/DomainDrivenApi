using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    /// <summary>
    /// Used to get dtos based on given query
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadService<T, Q>
    {
        Task<T> ReadAsync(Q query);
    }
   
    /// <summary>
    /// Return dto of T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadService<T>
    {
        Task<T> ReadAsync();
    }
}
