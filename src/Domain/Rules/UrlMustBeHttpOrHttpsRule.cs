using Domain.Common;
using Domain.Exceptions;
using System;

namespace Domain.Rules
{
    public class UrlMustBeHttpOrHttpsRule : IBusinessRule
    {
        private string _url;

        public UrlMustBeHttpOrHttpsRule(string url)
        {
            _url = url;
        }

        public void Enforce()
        {
            if (!Uri.TryCreate(_url, UriKind.Absolute, out var uri)
                || uri.Scheme != Uri.UriSchemeHttp
                || uri.Scheme != Uri.UriSchemeHttps)
                throw new UrlInvalidException(_url);
        }
    }
}
