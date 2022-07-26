
using Ganss.XSS;

namespace AloTaxi.Application.Utilities.Extensions
{
    public static class SecurityExtensions
    {
        public static string Sanitizer(this string value)
        {
            var htmlSanitizer = new HtmlSanitizer
            {
                AllowDataAttributes = true,
                KeepChildNodes = true
            };
            return htmlSanitizer.Sanitize(value);
        }
    }
}
