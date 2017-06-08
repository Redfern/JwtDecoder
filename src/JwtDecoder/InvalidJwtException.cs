using System;

namespace JwtTest
{
    public class InvalidJwtException : Exception
    {
        public InvalidJwtException(string message) : base(message) { }
    }
}
