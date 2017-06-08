using System;

namespace JwtTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // mock token created using https://jwt.io/
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoidGVzdGluZyBuYW1lIiwiZW1haWwiOiJ0ZXN0aW5nQGVtYWlsIn0.QmkqA7HE-nOPqxx5kSG5NqDyVeBXUiJ3_i-lwZAdVkw";
            var jwsDecoder = new JwtDecoder("dGhpcyBpcyBhIHNlY3JldCBrZXk=");

            Console.WriteLine("Decoding token to get payload....");
            var payload = jwsDecoder.Decode(token);

            Console.WriteLine("Success!!");
            Console.WriteLine("----------------");
            Console.WriteLine("Name is " + payload.Name);
            Console.WriteLine("Email is " + payload.Email);
            Console.WriteLine("----------------");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        } 
    }
}
