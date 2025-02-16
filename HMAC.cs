using System;
using System.Security.Cryptography;
using System.Text;

class HMACSHA256Example
{
    // Method to generate HMAC-SHA256
    public static string ComputeHMACSHA256(string message, string secretKey)
    {
        using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey)))
        {
            byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }

    public static void Main()
    {
        string message = "This is a secret message";
        string secretKey = "SuperSecretKey123";
        
        string hmacHash = ComputeHMACSHA256(message, secretKey);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Secret Key: " + secretKey);
        Console.WriteLine("HMAC-SHA256: " + hmacHash);
    }
}
