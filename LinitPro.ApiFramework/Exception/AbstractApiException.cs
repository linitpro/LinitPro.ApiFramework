using LinitPro.CommonTools.Extensions;

namespace LinitPro.ApiFramework.Exception
{
    public abstract class AbstractApiException<TResultCode>: System.Exception
    {
        protected AbstractApiException(TResultCode resultCode)
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
}