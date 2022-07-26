
namespace AloTaxi.Application.Utilities.Generators
{
    public static class CodeGenerator
    {
        public static string GenerateUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        public static string Generate8UniqueCharacter()
        {
            return Guid.NewGuid().ToString("N").Replace("-", "")[..8];
        }

        public static string ActivationCode()
        {
            return new Random().Next(10000, 99999).ToString();
        }
    }
}
