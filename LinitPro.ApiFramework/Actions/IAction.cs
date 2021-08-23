using System;
using System.Threading.Tasks;

namespace LinitPro.ApiFramework.Actions
{
    public interface IAction<TRequest, TResponse> 
        where TRequest: class
        where TResponse: class
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}