using System;

namespace ssolomon2024_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'.");
            
            // Cipher cipher;
            // cipher = new Cipher(5);

            // string encrypted;
            // encrypted = cipher.Encrypt("rosebud");
            // Console.WriteLine($"The encrypted message is: '{encrypted}'");

            // string decrypted;
            // decrypted = cipher.Decrypt(encrypted);
            // Console.WriteLine($"The decrypted message is: '{decrypted}'");
            
            string message;
            message = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"The encrypted message is: '{message}'");

            string decrypted;
            int shift;
            shift = 1;
            while (shift <= 10)
            {
            Cipher cipher;
            cipher = new Cipher(shift);
            decrypted = cipher.Decrypt(message);
            Console.WriteLine($"The decrypted message with shift {shift} is:'{decrypted}'");
            shift = shift + 1;
            }

            // Cipher cipher;
            // cipher = new Cipher(3);
            // decrypted = cipher.Decrypt(message);
            // Console.WriteLine($"The decrypted message is:'{decrypted}'");

        }
    }
}
