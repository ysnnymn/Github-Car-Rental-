using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encyption
{
	public class SecurityKeyHelper
	{
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(securityKey);

            // Anahtar boyutunu kontrol edin ve gerekirse artırın
            if (keyBytes.Length < 64)
            {
                Array.Resize(ref keyBytes, 64);
            }

            return new SymmetricSecurityKey(keyBytes);
        }
    }
}

