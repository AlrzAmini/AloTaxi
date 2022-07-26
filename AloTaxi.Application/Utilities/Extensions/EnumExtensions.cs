
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AloTaxi.Application.Utilities.Extensions
{
    public static class EnumExtensions
    {
        public static string? GetEnumName(this Enum value)
        {
            var enumName = value.GetType().GetMember(value.ToString()).FirstOrDefault();

            return enumName != null ? enumName.GetCustomAttribute<DisplayAttribute>()?.GetName() : "";
        }
    }
}
