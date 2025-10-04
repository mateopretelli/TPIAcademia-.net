using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Domain.Model.Security;
using System.Text;
using System.Threading.Tasks;

namespace Data.Security
{
    public class PasswordHasherPBKDF2 : IPasswordHasher
    {
        public (string Hash, string Salt) HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            string hash = Convert.ToBase64String(
                KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 310_000,
                    numBytesRequested: 32));        
            return (hash, Convert.ToBase64String(salt));
        }

        public bool VerifyPassword(string password, string storedHashBase64, string storedSaltBase64)
        {
            byte[] salt = Convert.FromBase64String(storedSaltBase64);
            byte[] hashToCheck = KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 310_000,
                    numBytesRequested: 32);
            byte[] storedHash = Convert.FromBase64String(storedHashBase64);

            return CryptographicOperations.FixedTimeEquals(hashToCheck, storedHash);
        }
    }
}
