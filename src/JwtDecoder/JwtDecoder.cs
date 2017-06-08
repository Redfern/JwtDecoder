using Jose;
using Newtonsoft.Json;
using System;

namespace JwtTest
{
    public class JwtDecoder
    {
        private static string _secretKey;

        public JwtDecoder(string secretKey)
        {
            _secretKey = secretKey;
        }

        public Person Decode(string token)
        {
            try
            {
                // valid tokens are split into three sections by .'s
                if (token.Split('.').Length != 3) throw new InvalidJwtException("Invalid JWT token");

                return JWT.Decode<Person>(token, Convert.FromBase64String(_secretKey), JwsAlgorithm.HS256);
            }
            catch (Exception ex)
            {
                if (ex is IntegrityException)
                {
                    // TODO: Log exception rather than throwing it
                }

                if (ex is JsonReaderException)
                {
                    // TODO: Log exception rather than throwing it
                }

                throw;
            }
        }
    }
}
