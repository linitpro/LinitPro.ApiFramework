using System;

namespace LinitPro.ApiFramework.Actions
{
    public interface IAction<TRequest, TResponse> 
        where TRequest: class
        where TResponse: class
    {
        
    }
}