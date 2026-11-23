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
            Console.WriteLine("Welcome to the User Profile Manager!");

            // Issue 4: Change 'var' to explicit types (string, int, bool)
            string firstName = "Alex";
            string lastName = "Rivera";
            int userAge = 16;
            bool isActive = true;

            // Issue 3: Use string.IsNullOrWhiteSpace() instead of null/empty checks
            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("Error: First name cannot be empty.");
                return;
            }

            // Issue 6: Use String Interpolation ($"...") instead of '+' signs
            string summary = $"User: {firstName} {lastName} | Age: {userAge} | Active: {isActive}";
            
            Console.WriteLine(summary);
            Console.WriteLine("Profile loaded successfully!");
        }
    }
}