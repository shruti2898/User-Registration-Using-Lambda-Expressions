using System;
using System.Text.RegularExpressions;

namespace UserRegistrationLambdaExpression
{
    class Program
    {
        static string Regex_FirstName = "^[A-Z][a-z]{2,}$";

        static string Regex_MobileNumber = "^([0-9]{2}[ ])?[6-9][0-9]{9}$";

        static string Regex_Password = @"^(?=.{8,}$)(?=.*?[0-9])(?=.*[A-Z])[a-zA-Z0-9]*[#!@$^&-][a-zA-Z0-9]*$";

        static string Regex_Email = "^[a-z][a-z0-9]{2,}([-.+]{1}[a-z0-9]{3})?[@][a-z0-9]{1,}[.][a-z]{3}([.][a-z]{2,3})?$";

        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================User Registration===============================================");
            Console.Write("\nPlease enter user details\n");

            Console.Write("First Name:     ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name:     ");
            string lastName = Console.ReadLine();

            Console.Write("Email:     ");
            string email = Console.ReadLine();

            Console.Write("Mobile Number:     ");
            string mobile = Console.ReadLine();

            Console.Write("Password:     ");
            string password = Console.ReadLine();


            Func<string, bool> isValidName = s => Regex.IsMatch(s, Regex_FirstName);
            Func<string, bool> isValidMobileNumber = s => Regex.IsMatch(s, Regex_MobileNumber);
            Func<string, bool> isValidPassword = s => Regex.IsMatch(s, Regex_Password);
            Func<string, bool> isValidEmail = s => Regex.IsMatch(s, Regex_Email);


            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4} ",
                              (isValidName(firstName)) ? "First name is valid" : "First name is invalid",
                              (isValidName(lastName)) ? "Last name is valid" : "Last name is invalid",
                              (isValidEmail(email)) ? "Email address is valid" : "Email address is invalid",
                              (isValidMobileNumber(mobile)) ? "Mobile number is valid" : "Mobile number is invalid",
                              (isValidPassword(password)) ? "Password is valid" : "Password is invalid");


            
            Console.ReadKey();

        }
    }
}
