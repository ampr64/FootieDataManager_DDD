using Domain.Common;
using Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace Domain.ValueObjects
{
    public class Url : ValueObject
    {
        public string Value { get; private set; }

        private Url(string value) => Value = value;

        public static Url Of(string url)
        {
            if (IsValidUrl(url))
                throw new UrlInvalidException(url);

            return new Url(url);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        private static bool IsValidUrl(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri validatedUri))
                return validatedUri.Scheme == Uri.UriSchemeHttp
                    || validatedUri.Scheme == Uri.UriSchemeHttps;

            return false;
        }
    }
}
