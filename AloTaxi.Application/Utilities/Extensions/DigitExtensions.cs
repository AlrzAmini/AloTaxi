
namespace AloTaxi.Application.Utilities.Extensions
{
    public static class DigitExtensions
    {
        public static string ToNumeric(this int value)
        {
            return value.ToString("N0"); //"123,456"
        }

        public static string ToNumeric(this decimal value)
        {
            return value.ToString("N0");
        }

        public static string ToCurrency(this int value)
        {
            //fa-IR => current culture currency symbol => ریال
            //123456 => "123,123ریال"
            return value.ToString("C0");
        }

        public static string ToCurrency(this decimal value)
        {
            return value.ToString("C0");
        }

        public static string ToTooman(this long price)
        {
            return price.ToString("#,0") + " تومان ";
        }

        public static string ToTooman(this int price)
        {
            return price.ToString("#,0") + " تومان ";
        }
    }
}
