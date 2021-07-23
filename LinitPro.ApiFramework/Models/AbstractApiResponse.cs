using System;
using System.Net.Http.Headers;
using LinitPro.CommonTools.Extensions;

namespace LinitPro.ApiFramework.Models
{
    /// <summary>
    /// Абстрактный ответ системы
    /// </summary>
    /// <typeparam name="TResultCode"></typeparam>
    public abstract class AbstractApiResponse<TResultCode>
        where TResultCode: Enum
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultCode">Код результата ответа</param>
        protected AbstractApiResponse(TResultCode resultCode)
        {
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// Возвращает код результата ответа
        /// </summary>
        public TResultCode ResultCode
        {
            protected set;
            get;
        }

        /// <summary>
        /// Возвращает сообщение ответа
        /// </summary>
        public string Message => this.ResultCode.GetMessage();
    }
    
    /// <summary>
    /// Абстрактный ответ системы
    /// </summary>
    /// <typeparam name="TResultCode"></typeparam>
    /// <typeparam name="TData"></typeparam>
    public abstract class AbstractApiResponse<TResultCode, TData>: AbstractApiResponse<TResultCode>
        where TResultCode: Enum
        where TData: class
    {
        protected AbstractApiResponse(TResultCode resultCode, TData data):
            base(resultCode)
        {
            this.Data = data;
        }
        
        /// <summary>
        /// Возвращает данные ответа
        /// </summary>
        public TData Data
        {
            protected set;
            get;
        }
    }
}