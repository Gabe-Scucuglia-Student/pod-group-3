using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace UserProfileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Issue 1: Fix typos in the welcome message and comments
            Console.WriteLine("Welcom to the User Profle Manager!");


            // Issue 5: Delete these extra blank lines above and below


            // Issue 4: Change 'var' to explicit types (string, int, bool)
            var firstName = "Alex";
            var lastName = "Rivera";
            var userAge = 16;
            var isActive = true;

            // Issue 3: Use string.IsNullOrWhiteSpace() instead of null/empty checks
            if (firstName == null || firstName == "" || firstName == " ")
            {
                Console.WriteLine("Error: First name canot be empty.");
                return;
            }

            // Issue 6: Use String Interpolation ($"...") instead of '+' signs
            string summary = $"User: {firstName} {lastName} | Age: {userAge} | Active: {isActive}";
            
            Console.WriteLine(summary);
            Console.WriteLine("Profil loaded sucessfully!");
        }
    }
}