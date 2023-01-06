using Ganss.Xss;

namespace AloTaxi.Application.Utilities.Extensions
{
    // do this is service and create attr for sanitizer
    // todo : hash password
    // todo : sanitize inputs
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
