using System;

namespace Domain.Exceptions
{
    public class UrlInvalidException : Exception
    {
        public UrlInvalidException(string url)
            : base($"Url \"{url}\" is invalid. It must be compliant with HTTP or HTTPS schemes.")
        {
        }
    }
}
