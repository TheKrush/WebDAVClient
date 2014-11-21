using System;
using System.Runtime.Serialization;
using System.Web;

namespace WebDAVClient
{
    public class WebDAVException : HttpException
    {
        public WebDAVException()
        {
        }

        public WebDAVException(string message)
            : base(message)
        {
        }

        public WebDAVException(string message, int hr)
            : base(message, hr)
        {
        }

        public WebDAVException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public WebDAVException(int httpCode, string message, Exception innerException)
            : base(httpCode, message, innerException)
        {
        }

        public WebDAVException(int httpCode, string message)
            : base(httpCode, message)
        {
        }

        public WebDAVException(int httpCode, string message, int hr)
            : base(httpCode, message, hr)
        {
        }

        protected WebDAVException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
