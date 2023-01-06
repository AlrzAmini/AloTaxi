using Isopoh.Cryptography.Argon2;

namespace AloTaxi.Application.Utilities.Security.Hasher;

public static class PasswordHasher
{
    #region aragon 2

    public static string HashWithAragon2(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentNullException(nameof(password),"Cannot be empty");
        }

        return Argon2.Hash(password);
    }

    public static bool VerifyAragon2(string? hash, string? password)
    {
        if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(hash))
        {
            return false;
        }

        return Argon2.Verify(hash, password);
    }

    #endregion
}