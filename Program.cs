using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mincharecters = 6;
            int maxcharecters = 12;

            Console.Write("Enter the  number of charecters  (between " + mincharecters + " and " + maxcharecters + " characters): ");
            int passwordLength = int.Parse(Console.ReadLine());

            do
            {
               
                if (passwordLength < mincharecters || passwordLength > maxcharecters)
                {
                    Console.WriteLine("Password length must be between " + mincharecters + " and " + maxcharecters + " characters.");
                    Console.Write("Enter the desired password length (between " + mincharecters + " and " + maxcharecters + " characters): ");
                    passwordLength = int.Parse(Console.ReadLine());

                }
            } while (passwordLength < mincharecters|| passwordLength > maxcharecters);

            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            // Add or remove characters as desired

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            while (0 < passwordLength--)
            {
                password.Append(allowedChars[random.Next(allowedChars.Length)]);
            }

            Console.WriteLine("Random Password: " + password);
        }
    }
}